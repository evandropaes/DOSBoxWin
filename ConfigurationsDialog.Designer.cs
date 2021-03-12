namespace DosBlaster
{
    partial class ConfigurationsDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBrowseGame = new System.Windows.Forms.Button();
            this.cmdDefaults = new System.Windows.Forms.Button();
            this.ctlGameDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBrowseDosBox = new System.Windows.Forms.Button();
            this.cmdDetect = new System.Windows.Forms.Button();
            this.ctlDosBoxDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdBrowseGame);
            this.groupBox1.Controls.Add(this.cmdDefaults);
            this.groupBox1.Controls.Add(this.ctlGameDirectory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdBrowseDosBox);
            this.groupBox1.Controls.Add(this.cmdDetect);
            this.groupBox1.Controls.Add(this.ctlDosBoxDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directories";
            // 
            // cmdBrowseGame
            // 
            this.cmdBrowseGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowseGame.Location = new System.Drawing.Point(336, 58);
            this.cmdBrowseGame.Name = "cmdBrowseGame";
            this.cmdBrowseGame.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowseGame.TabIndex = 4;
            this.cmdBrowseGame.Text = "Browse";
            this.cmdBrowseGame.UseVisualStyleBackColor = true;
            this.cmdBrowseGame.Click += new System.EventHandler(this.cmdBrowseGame_Click);
            // 
            // cmdDefaults
            // 
            this.cmdDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDefaults.Location = new System.Drawing.Point(417, 58);
            this.cmdDefaults.Name = "cmdDefaults";
            this.cmdDefaults.Size = new System.Drawing.Size(75, 23);
            this.cmdDefaults.TabIndex = 5;
            this.cmdDefaults.Text = "Defaults";
            this.cmdDefaults.UseVisualStyleBackColor = true;
            this.cmdDefaults.Click += new System.EventHandler(this.cmdDefaults_Click);
            // 
            // ctlGameDirectory
            // 
            this.ctlGameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlGameDirectory.Location = new System.Drawing.Point(142, 60);
            this.ctlGameDirectory.Name = "ctlGameDirectory";
            this.ctlGameDirectory.Size = new System.Drawing.Size(187, 20);
            this.ctlGameDirectory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Games Directory";
            // 
            // cmdBrowseDosBox
            // 
            this.cmdBrowseDosBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBrowseDosBox.Location = new System.Drawing.Point(336, 32);
            this.cmdBrowseDosBox.Name = "cmdBrowseDosBox";
            this.cmdBrowseDosBox.Size = new System.Drawing.Size(75, 23);
            this.cmdBrowseDosBox.TabIndex = 1;
            this.cmdBrowseDosBox.Text = "Browse";
            this.cmdBrowseDosBox.UseVisualStyleBackColor = true;
            this.cmdBrowseDosBox.Click += new System.EventHandler(this.cmdBrowseDosBox_Click);
            // 
            // cmdDetect
            // 
            this.cmdDetect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDetect.Location = new System.Drawing.Point(417, 32);
            this.cmdDetect.Name = "cmdDetect";
            this.cmdDetect.Size = new System.Drawing.Size(75, 23);
            this.cmdDetect.TabIndex = 2;
            this.cmdDetect.Text = "Detect";
            this.cmdDetect.UseVisualStyleBackColor = true;
            this.cmdDetect.Click += new System.EventHandler(this.cmdDetect_Click);
            // 
            // ctlDosBoxDirectory
            // 
            this.ctlDosBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlDosBoxDirectory.Location = new System.Drawing.Point(142, 34);
            this.ctlDosBoxDirectory.Name = "ctlDosBoxDirectory";
            this.ctlDosBoxDirectory.Size = new System.Drawing.Size(187, 20);
            this.ctlDosBoxDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dos Box Directory";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(435, 118);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Location = new System.Drawing.Point(354, 118);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 6;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // ConfigurationsDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(522, 153);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigurationsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBrowseGame;
        private System.Windows.Forms.Button cmdDefaults;
        private System.Windows.Forms.TextBox ctlGameDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdBrowseDosBox;
        private System.Windows.Forms.Button cmdDetect;
        private System.Windows.Forms.TextBox ctlDosBoxDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
    }
}