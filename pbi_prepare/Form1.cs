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
        private string destination_folder = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            this.source_file = ((TextBox)sender).Text;
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            this.destination_folder = ((TextBox)sender).Text;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtSource.Text = ofd.FileName;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                this.txtDestination.Text = fbd.SelectedPath;
            }
        }

        private void btnExtractFile_Click(object sender, EventArgs e)
        {
            if (this.ExtractZipFile(this.source_file, "", this.destination_folder))
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

    }
}
