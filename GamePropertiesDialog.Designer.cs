namespace DosBlaster
{
    partial class GamePropertiesDialog
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
            this.components = new System.ComponentModel.Container();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.ctlYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlPublisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlDirectoryName = new System.Windows.Forms.TextBox();
            this.ctlCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlTitle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlDOS32A = new System.Windows.Forms.RadioButton();
            this.ctlDOS4GW = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlAutoexec = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(224, 337);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Location = new System.Drawing.Point(143, 337);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(287, 319);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ctlYear);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ctlPublisher);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ctlDirectoryName);
            this.tabPage1.Controls.Add(this.ctlCategory);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctlTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(279, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Game Year";
            // 
            // ctlYear
            // 
            this.ctlYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlYear.Location = new System.Drawing.Point(9, 180);
            this.ctlYear.Name = "ctlYear";
            this.ctlYear.Size = new System.Drawing.Size(264, 20);
            this.ctlYear.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Game Publisher";
            // 
            // ctlPublisher
            // 
            this.ctlPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlPublisher.Location = new System.Drawing.Point(9, 141);
            this.ctlPublisher.Name = "ctlPublisher";
            this.ctlPublisher.Size = new System.Drawing.Size(264, 20);
            this.ctlPublisher.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Directory Name";
            // 
            // ctlDirectoryName
            // 
            this.ctlDirectoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlDirectoryName.Location = new System.Drawing.Point(9, 23);
            this.ctlDirectoryName.Name = "ctlDirectoryName";
            this.ctlDirectoryName.ReadOnly = true;
            this.ctlDirectoryName.Size = new System.Drawing.Size(264, 20);
            this.ctlDirectoryName.TabIndex = 15;
            // 
            // ctlCategory
            // 
            this.ctlCategory.FormattingEnabled = true;
            this.ctlCategory.Items.AddRange(new object[] {
            "Not Set",
            "Action",
            "Adventure",
            "Application",
            "Education",
            "Puzzle",
            "RPG",
            "Simulation",
            "Sport",
            "Strategy",
            "War",
            "Others"});
            this.ctlCategory.Location = new System.Drawing.Point(9, 101);
            this.ctlCategory.Name = "ctlCategory";
            this.ctlCategory.Size = new System.Drawing.Size(264, 21);
            this.ctlCategory.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Game Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Game Title";
            // 
            // ctlTitle
            // 
            this.ctlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlTitle.Location = new System.Drawing.Point(9, 62);
            this.ctlTitle.Name = "ctlTitle";
            this.ctlTitle.Size = new System.Drawing.Size(264, 20);
            this.ctlTitle.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlDOS32A);
            this.tabPage2.Controls.Add(this.ctlDOS4GW);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(279, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tools";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlDOS32A
            // 
            this.ctlDOS32A.Appearance = System.Windows.Forms.Appearance.Button;
            this.ctlDOS32A.Location = new System.Drawing.Point(119, 29);
            this.ctlDOS32A.Name = "ctlDOS32A";
            this.ctlDOS32A.Size = new System.Drawing.Size(104, 24);
            this.ctlDOS32A.TabIndex = 8;
            this.ctlDOS32A.TabStop = true;
            this.ctlDOS32A.Text = "DOS32A";
            this.ctlDOS32A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctlDOS32A.UseVisualStyleBackColor = true;
            this.ctlDOS32A.Click += new System.EventHandler(this.ctlDOS32A_Click);
            // 
            // ctlDOS4GW
            // 
            this.ctlDOS4GW.Appearance = System.Windows.Forms.Appearance.Button;
            this.ctlDOS4GW.Location = new System.Drawing.Point(9, 29);
            this.ctlDOS4GW.Name = "ctlDOS4GW";
            this.ctlDOS4GW.Size = new System.Drawing.Size(104, 24);
            this.ctlDOS4GW.TabIndex = 7;
            this.ctlDOS4GW.TabStop = true;
            this.ctlDOS4GW.Text = "DOS4GW";
            this.ctlDOS4GW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctlDOS4GW.UseVisualStyleBackColor = true;
            this.ctlDOS4GW.Click += new System.EventHandler(this.ctlDOS4GW_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Change Dos Extender";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.ctlAutoexec);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(279, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Autoexec.bat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 35);
            this.label7.TabIndex = 7;
            this.label7.Text = "Please refer to DosBox readme.txt for more information.";
            // 
            // ctlAutoexec
            // 
            this.ctlAutoexec.AcceptsReturn = true;
            this.ctlAutoexec.Location = new System.Drawing.Point(6, 46);
            this.ctlAutoexec.Multiline = true;
            this.ctlAutoexec.Name = "ctlAutoexec";
            this.ctlAutoexec.Size = new System.Drawing.Size(267, 240);
            this.ctlAutoexec.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GamePropertiesDialog
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(311, 372);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdCancel);
            this.Name = "GamePropertiesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Properties";
            this.Load += new System.EventHandler(this.GamePropertiesDialog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ctlYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctlPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctlDirectoryName;
        private System.Windows.Forms.ComboBox ctlCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctlTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton ctlDOS32A;
        private System.Windows.Forms.RadioButton ctlDOS4GW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctlAutoexec;
        private System.Windows.Forms.ImageList imageList1;
    }
}