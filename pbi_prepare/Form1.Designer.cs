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
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnExtractFile = new System.Windows.Forms.Button();
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
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(136, 42);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(251, 20);
            this.txtDestination.TabIndex = 0;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination pbix file";
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
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(393, 40);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(30, 23);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnExtractFile
            // 
            this.btnExtractFile.Location = new System.Drawing.Point(193, 86);
            this.btnExtractFile.Name = "btnExtractFile";
            this.btnExtractFile.Size = new System.Drawing.Size(75, 23);
            this.btnExtractFile.TabIndex = 3;
            this.btnExtractFile.Text = "Extract File";
            this.btnExtractFile.UseVisualStyleBackColor = true;
            this.btnExtractFile.Click += new System.EventHandler(this.btnExtractFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 134);
            this.Controls.Add(this.btnExtractFile);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestination);
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
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnExtractFile;
    }
}

