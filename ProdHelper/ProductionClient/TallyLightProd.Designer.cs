namespace ProdHelper.ProductionClient
{
    partial class TallyLightProd
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
            this.TallyLightCamListBox = new System.Windows.Forms.ListBox();
            this.tallyLightCamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TallyLightAddBtn = new System.Windows.Forms.Button();
            this.TallyLightRemoveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CameraNameLbl = new System.Windows.Forms.Label();
            this.SceneNameLbl = new System.Windows.Forms.Label();
            this.CameraNameTxt = new System.Windows.Forms.TextBox();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.SeperatorLbl = new System.Windows.Forms.Label();
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.SetServerBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ProdNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WebsocketPasswordTxt = new System.Windows.Forms.TextBox();
            this.StartWebsocketBtn = new System.Windows.Forms.Button();
            this.WebsocketServerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WebsocketLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ShowPasswordChk = new System.Windows.Forms.CheckBox();
            this.SceneComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tallyLightCamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TallyLightCamListBox
            // 
            this.TallyLightCamListBox.DataSource = this.tallyLightCamBindingSource;
            this.TallyLightCamListBox.DisplayMember = "CameraName";
            this.TallyLightCamListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TallyLightCamListBox.FormattingEnabled = true;
            this.TallyLightCamListBox.ItemHeight = 15;
            this.TallyLightCamListBox.Location = new System.Drawing.Point(16, 26);
            this.TallyLightCamListBox.Name = "TallyLightCamListBox";
            this.TallyLightCamListBox.Size = new System.Drawing.Size(156, 319);
            this.TallyLightCamListBox.TabIndex = 0;
            this.TallyLightCamListBox.ValueMember = "CameraName";
            this.TallyLightCamListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TallyLightCamListBox_DrawItem);
            this.TallyLightCamListBox.SelectedIndexChanged += new System.EventHandler(this.TallyLightCamListBox_SelectedIndexChanged);
            // 
            // tallyLightCamBindingSource
            // 
            this.tallyLightCamBindingSource.DataSource = typeof(ProdHelper.Models.TallyLightCam);
            // 
            // TallyLightAddBtn
            // 
            this.TallyLightAddBtn.Location = new System.Drawing.Point(16, 359);
            this.TallyLightAddBtn.Name = "TallyLightAddBtn";
            this.TallyLightAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TallyLightAddBtn.TabIndex = 1;
            this.TallyLightAddBtn.Text = "Add";
            this.TallyLightAddBtn.UseVisualStyleBackColor = true;
            this.TallyLightAddBtn.Click += new System.EventHandler(this.TallyLightAddBtn_Click);
            // 
            // TallyLightRemoveBtn
            // 
            this.TallyLightRemoveBtn.Location = new System.Drawing.Point(97, 359);
            this.TallyLightRemoveBtn.Name = "TallyLightRemoveBtn";
            this.TallyLightRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.TallyLightRemoveBtn.TabIndex = 2;
            this.TallyLightRemoveBtn.Text = "Remove";
            this.TallyLightRemoveBtn.UseVisualStyleBackColor = true;
            this.TallyLightRemoveBtn.Click += new System.EventHandler(this.TallyLightRemoveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Location = new System.Drawing.Point(272, 92);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(146, 23);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CameraNameLbl
            // 
            this.CameraNameLbl.AutoSize = true;
            this.CameraNameLbl.Location = new System.Drawing.Point(178, 37);
            this.CameraNameLbl.Name = "CameraNameLbl";
            this.CameraNameLbl.Size = new System.Drawing.Size(86, 15);
            this.CameraNameLbl.TabIndex = 99;
            this.CameraNameLbl.Text = "Camera Name:";
            // 
            // SceneNameLbl
            // 
            this.SceneNameLbl.AutoSize = true;
            this.SceneNameLbl.Location = new System.Drawing.Point(188, 66);
            this.SceneNameLbl.Name = "SceneNameLbl";
            this.SceneNameLbl.Size = new System.Drawing.Size(76, 15);
            this.SceneNameLbl.TabIndex = 99;
            this.SceneNameLbl.Text = "Scene Name:";
            // 
            // CameraNameTxt
            // 
            this.CameraNameTxt.Enabled = false;
            this.CameraNameTxt.Location = new System.Drawing.Point(272, 34);
            this.CameraNameTxt.Name = "CameraNameTxt";
            this.CameraNameTxt.Size = new System.Drawing.Size(146, 23);
            this.CameraNameTxt.TabIndex = 3;
            // 
            // ServerLbl
            // 
            this.ServerLbl.AutoSize = true;
            this.ServerLbl.Location = new System.Drawing.Point(210, 167);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(42, 15);
            this.ServerLbl.TabIndex = 9;
            this.ServerLbl.Text = "Server:";
            // 
            // SeperatorLbl
            // 
            this.SeperatorLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeperatorLbl.Location = new System.Drawing.Point(178, 124);
            this.SeperatorLbl.Name = "SeperatorLbl";
            this.SeperatorLbl.Size = new System.Drawing.Size(240, 2);
            this.SeperatorLbl.TabIndex = 10;
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(260, 164);
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(158, 23);
            this.ServerTxt.TabIndex = 6;
            // 
            // SetServerBtn
            // 
            this.SetServerBtn.Location = new System.Drawing.Point(260, 222);
            this.SetServerBtn.Name = "SetServerBtn";
            this.SetServerBtn.Size = new System.Drawing.Size(78, 23);
            this.SetServerBtn.TabIndex = 8;
            this.SetServerBtn.Text = "Apply";
            this.SetServerBtn.UseVisualStyleBackColor = true;
            this.SetServerBtn.Click += new System.EventHandler(this.SetServerBtn_ClickAsync);
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Location = new System.Drawing.Point(340, 222);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(78, 23);
            this.StartBtn.TabIndex = 9;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ProdNameTxt
            // 
            this.ProdNameTxt.Location = new System.Drawing.Point(260, 193);
            this.ProdNameTxt.Name = "ProdNameTxt";
            this.ProdNameTxt.Size = new System.Drawing.Size(158, 23);
            this.ProdNameTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password:";
            // 
            // WebsocketPasswordTxt
            // 
            this.WebsocketPasswordTxt.Location = new System.Drawing.Point(261, 330);
            this.WebsocketPasswordTxt.Name = "WebsocketPasswordTxt";
            this.WebsocketPasswordTxt.PasswordChar = '*';
            this.WebsocketPasswordTxt.Size = new System.Drawing.Size(69, 23);
            this.WebsocketPasswordTxt.TabIndex = 11;
            // 
            // StartWebsocketBtn
            // 
            this.StartWebsocketBtn.Location = new System.Drawing.Point(261, 359);
            this.StartWebsocketBtn.Name = "StartWebsocketBtn";
            this.StartWebsocketBtn.Size = new System.Drawing.Size(122, 23);
            this.StartWebsocketBtn.TabIndex = 13;
            this.StartWebsocketBtn.Text = "Start";
            this.StartWebsocketBtn.UseVisualStyleBackColor = true;
            this.StartWebsocketBtn.Click += new System.EventHandler(this.StartWebsocketBtn_Click);
            // 
            // WebsocketServerTxt
            // 
            this.WebsocketServerTxt.Location = new System.Drawing.Point(261, 303);
            this.WebsocketServerTxt.Name = "WebsocketServerTxt";
            this.WebsocketServerTxt.Size = new System.Drawing.Size(122, 23);
            this.WebsocketServerTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Server:";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(181, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 2);
            this.label4.TabIndex = 22;
            // 
            // WebsocketLbl
            // 
            this.WebsocketLbl.AutoSize = true;
            this.WebsocketLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WebsocketLbl.Location = new System.Drawing.Point(230, 272);
            this.WebsocketLbl.Name = "WebsocketLbl";
            this.WebsocketLbl.Size = new System.Drawing.Size(179, 21);
            this.WebsocketLbl.TabIndex = 23;
            this.WebsocketLbl.Text = "OBS Websocket Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(258, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Server Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(258, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Camera Settings";
            // 
            // ShowPasswordChk
            // 
            this.ShowPasswordChk.AutoSize = true;
            this.ShowPasswordChk.Location = new System.Drawing.Point(336, 332);
            this.ShowPasswordChk.Name = "ShowPasswordChk";
            this.ShowPasswordChk.Size = new System.Drawing.Size(55, 19);
            this.ShowPasswordChk.TabIndex = 12;
            this.ShowPasswordChk.Text = "Show";
            this.ShowPasswordChk.UseVisualStyleBackColor = true;
            this.ShowPasswordChk.CheckedChanged += new System.EventHandler(this.ShowPasswordChk_CheckedChanged);
            // 
            // SceneComboBox
            // 
            this.SceneComboBox.Enabled = false;
            this.SceneComboBox.FormattingEnabled = true;
            this.SceneComboBox.Location = new System.Drawing.Point(272, 63);
            this.SceneComboBox.Name = "SceneComboBox";
            this.SceneComboBox.Size = new System.Drawing.Size(146, 23);
            this.SceneComboBox.TabIndex = 4;
            this.SceneComboBox.DropDown += new System.EventHandler(this.SceneComboBox_DropDown);
            this.SceneComboBox.DropDownClosed += new System.EventHandler(this.SceneComboBox_DropDownClosed);
            // 
            // TallyLightProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 406);
            this.Controls.Add(this.SceneComboBox);
            this.Controls.Add(this.ShowPasswordChk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WebsocketLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WebsocketPasswordTxt);
            this.Controls.Add(this.StartWebsocketBtn);
            this.Controls.Add(this.WebsocketServerTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdNameTxt);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SetServerBtn);
            this.Controls.Add(this.ServerTxt);
            this.Controls.Add(this.SeperatorLbl);
            this.Controls.Add(this.ServerLbl);
            this.Controls.Add(this.CameraNameTxt);
            this.Controls.Add(this.SceneNameLbl);
            this.Controls.Add(this.CameraNameLbl);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.TallyLightRemoveBtn);
            this.Controls.Add(this.TallyLightAddBtn);
            this.Controls.Add(this.TallyLightCamListBox);
            this.Name = "TallyLightProd";
            this.Text = "Tally Light (Production)";
            this.Load += new System.EventHandler(this.TallyLightProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallyLightCamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox TallyLightCamListBox;
        private BindingSource tallyLightCamBindingSource;
        private Button TallyLightAddBtn;
        private Button TallyLightRemoveBtn;
        private Button UpdateBtn;
        private Label CameraNameLbl;
        private Label SceneNameLbl;
        private TextBox CameraNameTxt;
        private Label ServerLbl;
        private Label SeperatorLbl;
        private TextBox ServerTxt;
        private Button SetServerBtn;
        private Button StartBtn;
        private TextBox ProdNameTxt;
        private Label label1;
        private Label label2;
        private TextBox WebsocketPasswordTxt;
        private Button StartWebsocketBtn;
        private TextBox WebsocketServerTxt;
        private Label label3;
        private Label label4;
        private Label WebsocketLbl;
        private Label label5;
        private Label label6;
        private CheckBox ShowPasswordChk;
        private ComboBox SceneComboBox;
    }
}