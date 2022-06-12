namespace ProdHelper.ObserverClient
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
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(103, 104);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(183, 23);
            this.ApplyBtn.TabIndex = 4;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(103, 17);
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(183, 23);
            this.ServerTxt.TabIndex = 1;
            // 
            // CameraNameTxt
            // 
            this.CameraNameTxt.Location = new System.Drawing.Point(103, 75);
            this.CameraNameTxt.Name = "CameraNameTxt";
            this.CameraNameTxt.Size = new System.Drawing.Size(183, 23);
            this.CameraNameTxt.TabIndex = 3;
            // 
            // ServerLbl
            // 
            this.ServerLbl.AutoSize = true;
            this.ServerLbl.Location = new System.Drawing.Point(55, 20);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(42, 15);
            this.ServerLbl.TabIndex = 99;
            this.ServerLbl.Text = "Server:";
            // 
            // CamerNameLbl
            // 
            this.CamerNameLbl.AutoSize = true;
            this.CamerNameLbl.Location = new System.Drawing.Point(11, 78);
            this.CamerNameLbl.Name = "CamerNameLbl";
            this.CamerNameLbl.Size = new System.Drawing.Size(86, 15);
            this.CamerNameLbl.TabIndex = 9;
            this.CamerNameLbl.Text = "Camera Name:";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Enabled = false;
            this.OpenBtn.Location = new System.Drawing.Point(12, 187);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(274, 60);
            this.OpenBtn.TabIndex = 6;
            this.OpenBtn.Text = "Open Tally Light";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // ProdNameTxt
            // 
            this.ProdNameTxt.Location = new System.Drawing.Point(103, 46);
            this.ProdNameTxt.Name = "ProdNameTxt";
            this.ProdNameTxt.Size = new System.Drawing.Size(183, 23);
            this.ProdNameTxt.TabIndex = 2;
            // 
            // ProdLbl
            // 
            this.ProdLbl.AutoSize = true;
            this.ProdLbl.Location = new System.Drawing.Point(34, 49);
            this.ProdLbl.Name = "ProdLbl";
            this.ProdLbl.Size = new System.Drawing.Size(58, 15);
            this.ProdLbl.TabIndex = 99;
            this.ProdLbl.Text = "Producer:";
            // 
            // ApplicationComboBox
            // 
            this.ApplicationComboBox.Enabled = false;
            this.ApplicationComboBox.FormattingEnabled = true;
            this.ApplicationComboBox.Location = new System.Drawing.Point(123, 155);
            this.ApplicationComboBox.Name = "ApplicationComboBox";
            this.ApplicationComboBox.Size = new System.Drawing.Size(162, 23);
            this.ApplicationComboBox.TabIndex = 5;
            this.ApplicationComboBox.DropDown += new System.EventHandler(this.ApplicationComboBox_DropDown);
            this.ApplicationComboBox.SelectedIndexChanged += new System.EventHandler(this.ApplicationComboBox_SelectedIndexChanged);
            this.ApplicationComboBox.TextUpdate += new System.EventHandler(this.ApplicationComboBox_TextUpdate);
            // 
            // ApplicationLbl
            // 
            this.ApplicationLbl.AutoSize = true;
            this.ApplicationLbl.Location = new System.Drawing.Point(12, 158);
            this.ApplicationLbl.Name = "ApplicationLbl";
            this.ApplicationLbl.Size = new System.Drawing.Size(105, 15);
            this.ApplicationLbl.TabIndex = 99;
            this.ApplicationLbl.Text = "Select Application:";
            // 
            // OverlayAppChk
            // 
            this.OverlayAppChk.AutoSize = true;
            this.OverlayAppChk.Location = new System.Drawing.Point(123, 131);
            this.OverlayAppChk.Name = "OverlayAppChk";
            this.OverlayAppChk.Size = new System.Drawing.Size(130, 19);
            this.OverlayAppChk.TabIndex = 100;
            this.OverlayAppChk.Text = "Overlay Application";
            this.OverlayAppChk.UseVisualStyleBackColor = true;
            this.OverlayAppChk.CheckedChanged += new System.EventHandler(this.OverlayAppChk_CheckedChanged);
            // 
            // TallyLightObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 259);
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
            this.Name = "TallyLightObserver";
            this.Text = "Tally Light (Observer)";
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
    }
}