namespace pbi_prepare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtractTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnExtractTo = new System.Windows.Forms.Button();
            this.btnExtractFile = new System.Windows.Forms.Button();
            this.btnCompressFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnCreateJsonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(136, 16);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(251, 20);
            this.txtSource.TabIndex = 0;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source pbix file";
            // 
            // txtExtractTo
            // 
            this.txtExtractTo.Location = new System.Drawing.Point(136, 42);
            this.txtExtractTo.Name = "txtExtractTo";
            this.txtExtractTo.ReadOnly = true;
            this.txtExtractTo.Size = new System.Drawing.Size(251, 20);
            this.txtExtractTo.TabIndex = 0;
            this.txtExtractTo.TextChanged += new System.EventHandler(this.txtExtractTo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Extract to";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(393, 14);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(30, 23);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnExtractTo
            // 
            this.btnExtractTo.Location = new System.Drawing.Point(393, 40);
            this.btnExtractTo.Name = "btnExtractTo";
            this.btnExtractTo.Size = new System.Drawing.Size(30, 23);
            this.btnExtractTo.TabIndex = 2;
            this.btnExtractTo.Text = "...";
            this.btnExtractTo.UseVisualStyleBackColor = true;
            this.btnExtractTo.Click += new System.EventHandler(this.btnExtractTo_Click);
            // 
            // btnExtractFile
            // 
            this.btnExtractFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtractFile.Location = new System.Drawing.Point(222, 119);
            this.btnExtractFile.Name = "btnExtractFile";
            this.btnExtractFile.Size = new System.Drawing.Size(111, 23);
            this.btnExtractFile.TabIndex = 3;
            this.btnExtractFile.Text = "Extract File";
            this.btnExtractFile.UseVisualStyleBackColor = true;
            this.btnExtractFile.Click += new System.EventHandler(this.btnExtractFile_Click);
            // 
            // btnCompressFile
            // 
            this.btnCompressFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompressFile.Location = new System.Drawing.Point(339, 119);
            this.btnCompressFile.Name = "btnCompressFile";
            this.btnCompressFile.Size = new System.Drawing.Size(111, 23);
            this.btnCompressFile.TabIndex = 4;
            this.btnCompressFile.Text = "Compress to Zip";
            this.btnCompressFile.UseVisualStyleBackColor = true;
            this.btnCompressFile.Click += new System.EventHandler(this.btnCompressFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destination pbix file";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(136, 69);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(251, 20);
            this.txtDestination.TabIndex = 5;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(393, 68);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(30, 23);
            this.btnDestination.TabIndex = 6;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnCreateJsonFile
            // 
            this.btnCreateJsonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateJsonFile.Location = new System.Drawing.Point(12, 119);
            this.btnCreateJsonFile.Name = "btnCreateJsonFile";
            this.btnCreateJsonFile.Size = new System.Drawing.Size(109, 23);
            this.btnCreateJsonFile.TabIndex = 7;
            this.btnCreateJsonFile.Text = "Create Json File";
            this.btnCreateJsonFile.UseVisualStyleBackColor = true;
            this.btnCreateJsonFile.Click += new System.EventHandler(this.btnCreateJsonFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 154);
            this.Controls.Add(this.btnCreateJsonFile);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.btnCompressFile);
            this.Controls.Add(this.btnExtractFile);
            this.Controls.Add(this.btnExtractTo);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtractTo);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtractTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnExtractTo;
        private System.Windows.Forms.Button btnExtractFile;
        private System.Windows.Forms.Button btnCompressFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnCreateJsonFile;
    }
}

