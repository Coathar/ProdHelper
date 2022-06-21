namespace TallyLightObs
{
    partial class TallyLightObserver
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
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.CameraNameTxt = new System.Windows.Forms.TextBox();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.CamerNameLbl = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.ProdNameTxt = new System.Windows.Forms.TextBox();
            this.ProdLbl = new System.Windows.Forms.Label();
            this.ApplicationComboBox = new System.Windows.Forms.ComboBox();
            this.ApplicationLbl = new System.Windows.Forms.Label();
            this.OverlayAppChk = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(103, 128);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(183, 23);
            this.ApplyBtn.TabIndex = 4;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(103, 41);
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(183, 23);
            this.ServerTxt.TabIndex = 1;
            // 
            // CameraNameTxt
            // 
            this.CameraNameTxt.Location = new System.Drawing.Point(103, 99);
            this.CameraNameTxt.Name = "CameraNameTxt";
            this.CameraNameTxt.Size = new System.Drawing.Size(183, 23);
            this.CameraNameTxt.TabIndex = 3;
            // 
            // ServerLbl
            // 
            this.ServerLbl.AutoSize = true;
            this.ServerLbl.Location = new System.Drawing.Point(55, 44);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(42, 15);
            this.ServerLbl.TabIndex = 99;
            this.ServerLbl.Text = "Server:";
            // 
            // CamerNameLbl
            // 
            this.CamerNameLbl.AutoSize = true;
            this.CamerNameLbl.Location = new System.Drawing.Point(11, 102);
            this.CamerNameLbl.Name = "CamerNameLbl";
            this.CamerNameLbl.Size = new System.Drawing.Size(86, 15);
            this.CamerNameLbl.TabIndex = 9;
            this.CamerNameLbl.Text = "Camera Name:";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Enabled = false;
            this.OpenBtn.Location = new System.Drawing.Point(12, 211);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(274, 60);
            this.OpenBtn.TabIndex = 7;
            this.OpenBtn.Text = "Open Tally Light";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // ProdNameTxt
            // 
            this.ProdNameTxt.Location = new System.Drawing.Point(103, 70);
            this.ProdNameTxt.Name = "ProdNameTxt";
            this.ProdNameTxt.Size = new System.Drawing.Size(183, 23);
            this.ProdNameTxt.TabIndex = 2;
            // 
            // ProdLbl
            // 
            this.ProdLbl.AutoSize = true;
            this.ProdLbl.Location = new System.Drawing.Point(34, 73);
            this.ProdLbl.Name = "ProdLbl";
            this.ProdLbl.Size = new System.Drawing.Size(58, 15);
            this.ProdLbl.TabIndex = 99;
            this.ProdLbl.Text = "Producer:";
            // 
            // ApplicationComboBox
            // 
            this.ApplicationComboBox.Enabled = false;
            this.ApplicationComboBox.FormattingEnabled = true;
            this.ApplicationComboBox.Location = new System.Drawing.Point(123, 179);
            this.ApplicationComboBox.Name = "ApplicationComboBox";
            this.ApplicationComboBox.Size = new System.Drawing.Size(162, 23);
            this.ApplicationComboBox.TabIndex = 6;
            this.ApplicationComboBox.DropDown += new System.EventHandler(this.ApplicationComboBox_DropDown);
            this.ApplicationComboBox.SelectedIndexChanged += new System.EventHandler(this.ApplicationComboBox_SelectedIndexChanged);
            this.ApplicationComboBox.TextUpdate += new System.EventHandler(this.ApplicationComboBox_TextUpdate);
            // 
            // ApplicationLbl
            // 
            this.ApplicationLbl.AutoSize = true;
            this.ApplicationLbl.Location = new System.Drawing.Point(12, 182);
            this.ApplicationLbl.Name = "ApplicationLbl";
            this.ApplicationLbl.Size = new System.Drawing.Size(105, 15);
            this.ApplicationLbl.TabIndex = 99;
            this.ApplicationLbl.Text = "Select Application:";
            // 
            // OverlayAppChk
            // 
            this.OverlayAppChk.AutoSize = true;
            this.OverlayAppChk.Location = new System.Drawing.Point(123, 155);
            this.OverlayAppChk.Name = "OverlayAppChk";
            this.OverlayAppChk.Size = new System.Drawing.Size(130, 19);
            this.OverlayAppChk.TabIndex = 5;
            this.OverlayAppChk.Text = "Overlay Application";
            this.OverlayAppChk.UseVisualStyleBackColor = true;
            this.OverlayAppChk.CheckedChanged += new System.EventHandler(this.OverlayAppChk_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 100;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRecentToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightSizeToolStripMenuItem,
            this.lightShapeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // loadRecentToolStripMenuItem
            // 
            this.loadRecentToolStripMenuItem.Name = "loadRecentToolStripMenuItem";
            this.loadRecentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadRecentToolStripMenuItem.Text = "Load Recent...";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // lightSizeToolStripMenuItem
            // 
            this.lightSizeToolStripMenuItem.Name = "lightSizeToolStripMenuItem";
            this.lightSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightSizeToolStripMenuItem.Text = "Light Size";
            this.lightSizeToolStripMenuItem.Click += new System.EventHandler(this.lightSizeToolStripMenuItem_Click);
            // 
            // lightShapeToolStripMenuItem
            // 
            this.lightShapeToolStripMenuItem.Name = "lightShapeToolStripMenuItem";
            this.lightShapeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightShapeToolStripMenuItem.Text = "Light Shape";
            // 
            // TallyLightObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 288);
            this.Controls.Add(this.OverlayAppChk);
            this.Controls.Add(this.ApplicationLbl);
            this.Controls.Add(this.ApplicationComboBox);
            this.Controls.Add(this.ProdLbl);
            this.Controls.Add(this.ProdNameTxt);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.CamerNameLbl);
            this.Controls.Add(this.ServerLbl);
            this.Controls.Add(this.CameraNameTxt);
            this.Controls.Add(this.ServerTxt);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TallyLightObserver";
            this.Text = "Tally Light (Observer)";
            this.Load += new System.EventHandler(this.TallyLightObserver_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ApplyBtn;
        private TextBox ServerTxt;
        private TextBox CameraNameTxt;
        private Label ServerLbl;
        private Label CamerNameLbl;
        private Button OpenBtn;
        private TextBox ProdNameTxt;
        private Label ProdLbl;
        private ComboBox ApplicationComboBox;
        private Label ApplicationLbl;
        private CheckBox OverlayAppChk;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadRecentToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem lightSizeToolStripMenuItem;
        private ToolStripMenuItem lightShapeToolStripMenuItem;
    }
}