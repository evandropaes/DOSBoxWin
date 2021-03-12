namespace DosBlaster
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.iml = new System.Windows.Forms.ImageList(this.components);
            this.ctlScaler = new System.Windows.Forms.ComboBox();
            this.mnuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdPlayGame = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDeleteGame = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEMS = new System.Windows.Forms.CheckBox();
            this.ctlMachineType = new System.Windows.Forms.ComboBox();
            this.ctlSort = new System.Windows.Forms.ComboBox();
            this.ctlListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlCpuType = new System.Windows.Forms.ComboBox();
            this.userMenuStrip1 = new DosBlaster.UserMenuStrip();
            this.statusStrip = new DosBlaster.MyStatusStrip();
            this.mnuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // iml
            // 
            this.iml.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml.ImageStream")));
            this.iml.TransparentColor = System.Drawing.Color.Transparent;
            this.iml.Images.SetKeyName(0, "joystick.png");
            // 
            // ctlScaler
            // 
            this.ctlScaler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlScaler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlScaler.FormattingEnabled = true;
            this.ctlScaler.Items.AddRange(new object[] {
            "none",
            "normal2x",
            "normal3x",
            "advmame2x",
            "advmame3x",
            "advinterp2x",
            "advinterp3x",
            "hq2x",
            "hq3x",
            "2xsai",
            "super2xsai",
            "supereagle",
            "tv2x",
            "tv3x",
            "rgb2x",
            "rgb3x",
            "scan2x",
            "scan3x"});
            this.ctlScaler.Location = new System.Drawing.Point(534, 2);
            this.ctlScaler.Name = "ctlScaler";
            this.ctlScaler.Size = new System.Drawing.Size(99, 21);
            this.ctlScaler.TabIndex = 2;
            // 
            // mnuContext
            // 
            this.mnuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdPlayGame,
            this.cmdDeleteGame,
            this.cmdProperties});
            this.mnuContext.Name = "mnuContext";
            this.mnuContext.Size = new System.Drawing.Size(130, 70);
            // 
            // cmdPlayGame
            // 
            this.cmdPlayGame.Name = "cmdPlayGame";
            this.cmdPlayGame.Size = new System.Drawing.Size(129, 22);
            this.cmdPlayGame.Text = "Run Game";
            this.cmdPlayGame.Click += new System.EventHandler(this.cmdPlayGame_Click);
            // 
            // cmdDeleteGame
            // 
            this.cmdDeleteGame.Name = "cmdDeleteGame";
            this.cmdDeleteGame.Size = new System.Drawing.Size(129, 22);
            this.cmdDeleteGame.Text = "Delete";
            this.cmdDeleteGame.Click += new System.EventHandler(this.cmdDeleteGame_Click);
            // 
            // cmdProperties
            // 
            this.cmdProperties.Name = "cmdProperties";
            this.cmdProperties.Size = new System.Drawing.Size(129, 22);
            this.cmdProperties.Text = "Properties";
            this.cmdProperties.Click += new System.EventHandler(this.cmdProperties_Click);
            // 
            // ctlEMS
            // 
            this.ctlEMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlEMS.AutoSize = true;
            this.ctlEMS.BackColor = System.Drawing.Color.Transparent;
            this.ctlEMS.Checked = true;
            this.ctlEMS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlEMS.Location = new System.Drawing.Point(164, 4);
            this.ctlEMS.Name = "ctlEMS";
            this.ctlEMS.Size = new System.Drawing.Size(49, 17);
            this.ctlEMS.TabIndex = 7;
            this.ctlEMS.Text = "EMS";
            this.ctlEMS.UseVisualStyleBackColor = false;
            // 
            // ctlMachineType
            // 
            this.ctlMachineType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlMachineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlMachineType.FormattingEnabled = true;
            this.ctlMachineType.Items.AddRange(new object[] {
            "hercules",
            "cga",
            "tandy",
            "pcjr",
            "ega",
            "vgaonly",
            "svga_s3",
            "svga_et3000",
            "svga_et4000",
            "svga_paradise",
            "vesa_nolfb",
            "vesa_oldvbe"});
            this.ctlMachineType.Location = new System.Drawing.Point(429, 2);
            this.ctlMachineType.Name = "ctlMachineType";
            this.ctlMachineType.Size = new System.Drawing.Size(99, 21);
            this.ctlMachineType.TabIndex = 3;
            // 
            // ctlSort
            // 
            this.ctlSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlSort.FormattingEnabled = true;
            this.ctlSort.Items.AddRange(new object[] {
            "Category",
            "Publisher",
            "Year"});
            this.ctlSort.Location = new System.Drawing.Point(219, 2);
            this.ctlSort.Name = "ctlSort";
            this.ctlSort.Size = new System.Drawing.Size(99, 21);
            this.ctlSort.TabIndex = 8;
            this.ctlSort.SelectedIndexChanged += new System.EventHandler(this.ctlSort_SelectedIndexChanged);
            // 
            // ctlListView
            // 
            this.ctlListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlListView.LargeImageList = this.iml;
            this.ctlListView.Location = new System.Drawing.Point(0, 25);
            this.ctlListView.MultiSelect = false;
            this.ctlListView.Name = "ctlListView";
            this.ctlListView.Size = new System.Drawing.Size(635, 327);
            this.ctlListView.TabIndex = 0;
            this.ctlListView.UseCompatibleStateImageBehavior = false;
            this.ctlListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ctlListView_MouseDoubleClick);
            this.ctlListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctlListView_MouseClick);
            this.ctlListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ctlListView_ItemSelectionChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 1);
            this.label1.TabIndex = 9;
            // 
            // ctlCpuType
            // 
            this.ctlCpuType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlCpuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCpuType.FormattingEnabled = true;
            this.ctlCpuType.Items.AddRange(new object[] {
            "auto",
            "386",
            "386_slow",
            "486_slow",
            "pentium_slow",
            "386_prefetch"});
            this.ctlCpuType.Location = new System.Drawing.Point(324, 2);
            this.ctlCpuType.Name = "ctlCpuType";
            this.ctlCpuType.Size = new System.Drawing.Size(99, 21);
            this.ctlCpuType.TabIndex = 10;
            // 
            // userMenuStrip1
            // 
            this.userMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.userMenuStrip1.Name = "userMenuStrip1";
            this.userMenuStrip1.Size = new System.Drawing.Size(635, 24);
            this.userMenuStrip1.TabIndex = 4;
            this.userMenuStrip1.Text = "userMenuStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 352);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(635, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "myStatusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 374);
            this.Controls.Add(this.ctlCpuType);
            this.Controls.Add(this.ctlListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlMachineType);
            this.Controls.Add(this.ctlSort);
            this.Controls.Add(this.ctlScaler);
            this.Controls.Add(this.ctlEMS);
            this.Controls.Add(this.userMenuStrip1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DosBlaster 3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mnuContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ctlScaler;
        private UserMenuStrip userMenuStrip1;
        private System.Windows.Forms.ImageList iml;
        private System.Windows.Forms.ContextMenuStrip mnuContext;
        private System.Windows.Forms.ToolStripMenuItem cmdPlayGame;
        private System.Windows.Forms.ToolStripMenuItem cmdDeleteGame;
        private System.Windows.Forms.ToolStripMenuItem cmdProperties;
        private MyStatusStrip statusStrip;
        private System.Windows.Forms.CheckBox ctlEMS;
        private System.Windows.Forms.ComboBox ctlMachineType;
        private System.Windows.Forms.ComboBox ctlSort;
        private System.Windows.Forms.ListView ctlListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ctlCpuType;
    }
}

