using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace pbi_prepare
{
    public partial class Form1 : Form
    {
        private string source_file = null;
        private string extract_to_folder = null;
        private string destination_file = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            this.source_file = ((TextBox)sender).Text;
        }

        private void txtExtractTo_TextChanged(object sender, EventArgs e)
        {
            this.extract_to_folder = ((TextBox)sender).Text;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtSource.Text = ofd.FileName;
            }
        }

        private void btnExtractTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                this.txtExtractTo.Text = fbd.SelectedPath;
            }
        }

        private void btnExtractFile_Click(object sender, EventArgs e)
        {
            if (this.ExtractZipFile(this.source_file, "", this.extract_to_folder))
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
        public bool ExtractZipFile(string archivePath, string password, string outFolder)
        {
            try
            {
                using (Stream fsInput = File.OpenRead(archivePath))
                {
                    using (ZipFile zf = new ZipFile(fsInput))
                    {
                        if (!String.IsNullOrEmpty(password))
                        {
                            // AES encrypted entries are handled automatically
                            zf.Password = password;
                        }

                        foreach (ZipEntry zipEntry in zf)
                        {
                            if (!zipEntry.IsFile)
                            {
                                // Ignore directories
                                continue;
                            }
                            String entryFileName = zipEntry.Name;
                            // to remove the folder from the entry:
                            //entryFileName = Path.GetFileName(entryFileName);
                            // Optionally match entrynames against a selection list here
                            // to skip as desired.
                            // The unpacked length is available in the zipEntry.Size property.

                            // Manipulate the output filename here as desired.
                            var fullZipToPath = Path.Combine(outFolder, entryFileName);
                            var directoryName = Path.GetDirectoryName(fullZipToPath);
                            if (directoryName.Length > 0)
                            {
                                Directory.CreateDirectory(directoryName);
                            }

                            // 4K is optimum
                            var buffer = new byte[4096];

                            // Unzip file in buffered chunks. This is just as fast as unpacking
                            // to a buffer the full size of the file, but does not waste memory.
                            // The "using" will close the stream even if an exception occurs.
                            using (var zipStream = zf.GetInputStream(zipEntry))
                            using (Stream fsOutput = File.Create(fullZipToPath))
                            {
                                StreamUtils.Copy(zipStream, fsOutput, buffer);
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "new_pbix.pbix";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                this.txtDestination.Text = sfd.FileName;
            }
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            this.destination_file = ((TextBox)sender).Text;
        }

        private void btnCompressFile_Click(object sender, EventArgs e)
        {
            this.CreateSample(this.destination_file, "", this.extract_to_folder);
        }

        // Compresses the files in the nominated folder, and creates a zip file 
        // on disk named as outPathname.
        public void CreateSample(string outPathname, string password, string folderName)
        {

            using (FileStream fsOut = File.Create(outPathname))
            using (var zipStream = new ZipOutputStream(fsOut))
            {

                //0-9, 9 being the highest level of compression
                zipStream.SetLevel(3);

                // optional. Null is the same as not setting. Required if using AES.
                zipStream.Password = password;

                // This setting will strip the leading part of the folder path in the entries, 
                // to make the entries relative to the starting folder.
                // To include the full path for each entry up to the drive root, assign to 0.
                int folderOffset = folderName.Length + (folderName.EndsWith("\\") ? 0 : 1);

                CompressFolder(folderName, zipStream, folderOffset);

            }

        }

        public void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
        {
            var files = Directory.GetFiles(path);

            foreach (var filename in files)
            {

                var fi = new FileInfo(filename);

                // Make the name in zip based on the folder
                var entryName = filename.Substring(folderOffset);

                // Remove drive from name and fixe slash direction
                entryName = ZipEntry.CleanName(entryName);

                var newEntry = new ZipEntry(entryName);

                // Note the zip format stores 2 second granularity
                newEntry.DateTime = fi.LastWriteTime;

                // Specifying the AESKeySize triggers AES encryption. 
                // Allowable values are 0 (off), 128 or 256.
                // A password on the ZipOutputStream is required if using AES.
                //   newEntry.AESKeySize = 256;

                // To permit the zip to be unpacked by built-in extractor in WinXP and Server2003,
                // WinZip 8, Java, and other older code, you need to do one of the following: 
                // Specify UseZip64.Off, or set the Size.
                // If the file may be bigger than 4GB, or you do not need WinXP built-in compatibility, 
                // you do not need either, but the zip will be in Zip64 format which
                // not all utilities can understand.
                //   zipStream.UseZip64 = UseZip64.Off;
                newEntry.Size = fi.Length;

                zipStream.PutNextEntry(newEntry);

                // Zip the file in buffered chunks
                // the "using" will close the stream even if an exception occurs
                var buffer = new byte[4096];
                using (FileStream fsInput = File.OpenRead(filename))
                {
                    StreamUtils.Copy(fsInput, zipStream, buffer);
                }
                zipStream.CloseEntry();
            }

            // Recursively call CompressFolder on all folders in path
            var folders = Directory.GetDirectories(path);
            foreach (var folder in folders)
            {
                CompressFolder(folder, zipStream, folderOffset);
            }
        }

        private void btnCreateJsonFile_Click(object sender, EventArgs e)
        {

        }
    }
}
