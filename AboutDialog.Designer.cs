namespace DosBlaster
{
    partial class AboutDialog
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
            this.borderPanel1 = new DosBlaster.BorderPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlVersion = new System.Windows.Forms.Label();
            this.ctlAvailableMemory = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.ctlProductName = new System.Windows.Forms.Label();
            this.borderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderPanel1
            // 
            this.borderPanel1.BottomBorder = System.Drawing.Color.Transparent;
            this.borderPanel1.Controls.Add(this.ctlProductName);
            this.borderPanel1.Controls.Add(this.label3);
            this.borderPanel1.Controls.Add(this.label2);
            this.borderPanel1.Controls.Add(this.ctlVersion);
            this.borderPanel1.Controls.Add(this.ctlAvailableMemory);
            this.borderPanel1.Controls.Add(this.cmdOK);
            this.borderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel1.LeftBorder = System.Drawing.Color.Transparent;
            this.borderPanel1.Location = new System.Drawing.Point(0, 0);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.borderPanel1.RightBorder = System.Drawing.Color.Transparent;
            this.borderPanel1.Size = new System.Drawing.Size(455, 271);
            this.borderPanel1.TabIndex = 6;
            this.borderPanel1.TopBorder = System.Drawing.Color.Silver;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Please read license.txt for for information about licensing of this software.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Copyright 2010, 2011 by Ang Beng Siong. All Rights Reserved.";
            // 
            // ctlVersion
            // 
            this.ctlVersion.AutoSize = true;
            this.ctlVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlVersion.Location = new System.Drawing.Point(12, 30);
            this.ctlVersion.Name = "ctlVersion";
            this.ctlVersion.Size = new System.Drawing.Size(534, 16);
            this.ctlVersion.TabIndex = 7;
            this.ctlVersion.Text = "Version: 1.0 Build 32 Alpha (Windows NT 5.2; Microsoft.Net 2.0 SP2; Internet Expl" +
                "orer 7.00)";
            // 
            // ctlAvailableMemory
            // 
            this.ctlAvailableMemory.AutoSize = true;
            this.ctlAvailableMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlAvailableMemory.Location = new System.Drawing.Point(14, 51);
            this.ctlAvailableMemory.Name = "ctlAvailableMemory";
            this.ctlAvailableMemory.Size = new System.Drawing.Size(96, 16);
            this.ctlAvailableMemory.TabIndex = 6;
            this.ctlAvailableMemory.Text = "Memory Used:";
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdOK.Location = new System.Drawing.Point(190, 236);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 5;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click_1);
            // 
            // ctlProductName
            // 
            this.ctlProductName.AutoSize = true;
            this.ctlProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlProductName.Location = new System.Drawing.Point(12, 9);
            this.ctlProductName.Name = "ctlProductName";
            this.ctlProductName.Size = new System.Drawing.Size(534, 16);
            this.ctlProductName.TabIndex = 10;
            this.ctlProductName.Text = "Version: 1.0 Build 32 Alpha (Windows NT 5.2; Microsoft.Net 2.0 SP2; Internet Expl" +
                "orer 7.00)";
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 271);
            this.Controls.Add(this.borderPanel1);
            this.Name = "AboutDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About SuperNotePad";
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DosBlaster.BorderPanel borderPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ctlVersion;
        private System.Windows.Forms.Label ctlAvailableMemory;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ctlProductName;

    }
}