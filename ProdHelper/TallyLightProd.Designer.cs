namespace ProdHelper
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
            this.SceneNameTxt = new System.Windows.Forms.TextBox();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.SetServerBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tallyLightCamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TallyLightCamListBox
            // 
            this.TallyLightCamListBox.DataSource = this.tallyLightCamBindingSource;
            this.TallyLightCamListBox.DisplayMember = "CameraName";
            this.TallyLightCamListBox.FormattingEnabled = true;
            this.TallyLightCamListBox.ItemHeight = 15;
            this.TallyLightCamListBox.Location = new System.Drawing.Point(16, 26);
            this.TallyLightCamListBox.Name = "TallyLightCamListBox";
            this.TallyLightCamListBox.Size = new System.Drawing.Size(156, 364);
            this.TallyLightCamListBox.TabIndex = 0;
            this.TallyLightCamListBox.ValueMember = "CameraName";
            this.TallyLightCamListBox.SelectedIndexChanged += new System.EventHandler(this.TallyLightCamListBox_SelectedIndexChanged);
            // 
            // tallyLightCamBindingSource
            // 
            this.tallyLightCamBindingSource.DataSource = typeof(ProdHelper.TallyLightCam);
            // 
            // TallyLightAddBtn
            // 
            this.TallyLightAddBtn.Location = new System.Drawing.Point(16, 396);
            this.TallyLightAddBtn.Name = "TallyLightAddBtn";
            this.TallyLightAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TallyLightAddBtn.TabIndex = 1;
            this.TallyLightAddBtn.Text = "Add";
            this.TallyLightAddBtn.UseVisualStyleBackColor = true;
            this.TallyLightAddBtn.Click += new System.EventHandler(this.TallyLightAddBtn_Click);
            // 
            // TallyLightRemoveBtn
            // 
            this.TallyLightRemoveBtn.Location = new System.Drawing.Point(97, 396);
            this.TallyLightRemoveBtn.Name = "TallyLightRemoveBtn";
            this.TallyLightRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.TallyLightRemoveBtn.TabIndex = 2;
            this.TallyLightRemoveBtn.Text = "Remove";
            this.TallyLightRemoveBtn.UseVisualStyleBackColor = true;
            this.TallyLightRemoveBtn.Click += new System.EventHandler(this.TallyLightRemoveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(270, 87);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(122, 23);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CameraNameLbl
            // 
            this.CameraNameLbl.AutoSize = true;
            this.CameraNameLbl.Location = new System.Drawing.Point(178, 29);
            this.CameraNameLbl.Name = "CameraNameLbl";
            this.CameraNameLbl.Size = new System.Drawing.Size(86, 15);
            this.CameraNameLbl.TabIndex = 4;
            this.CameraNameLbl.Text = "Camera Name:";
            // 
            // SceneNameLbl
            // 
            this.SceneNameLbl.AutoSize = true;
            this.SceneNameLbl.Location = new System.Drawing.Point(188, 61);
            this.SceneNameLbl.Name = "SceneNameLbl";
            this.SceneNameLbl.Size = new System.Drawing.Size(76, 15);
            this.SceneNameLbl.TabIndex = 5;
            this.SceneNameLbl.Text = "Scene Name:";
            // 
            // CameraNameTxt
            // 
            this.CameraNameTxt.Location = new System.Drawing.Point(270, 26);
            this.CameraNameTxt.Name = "CameraNameTxt";
            this.CameraNameTxt.Size = new System.Drawing.Size(122, 23);
            this.CameraNameTxt.TabIndex = 6;
            // 
            // SceneNameTxt
            // 
            this.SceneNameTxt.Location = new System.Drawing.Point(270, 58);
            this.SceneNameTxt.Name = "SceneNameTxt";
            this.SceneNameTxt.Size = new System.Drawing.Size(122, 23);
            this.SceneNameTxt.TabIndex = 7;
            // 
            // ServerLbl
            // 
            this.ServerLbl.AutoSize = true;
            this.ServerLbl.Location = new System.Drawing.Point(222, 161);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(42, 15);
            this.ServerLbl.TabIndex = 9;
            this.ServerLbl.Text = "Server:";
            this.ServerLbl.Click += new System.EventHandler(this.ServerLbl_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(178, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 2);
            this.label3.TabIndex = 10;
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(270, 158);
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(122, 23);
            this.ServerTxt.TabIndex = 11;
            // 
            // SetServerBtn
            // 
            this.SetServerBtn.Location = new System.Drawing.Point(270, 187);
            this.SetServerBtn.Name = "SetServerBtn";
            this.SetServerBtn.Size = new System.Drawing.Size(122, 23);
            this.SetServerBtn.TabIndex = 12;
            this.SetServerBtn.Text = "Apply";
            this.SetServerBtn.UseVisualStyleBackColor = true;
            this.SetServerBtn.Click += new System.EventHandler(this.SetServerBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(270, 216);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(122, 23);
            this.StartBtn.TabIndex = 13;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // TallyLightProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SetServerBtn);
            this.Controls.Add(this.ServerTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerLbl);
            this.Controls.Add(this.SceneNameTxt);
            this.Controls.Add(this.CameraNameTxt);
            this.Controls.Add(this.SceneNameLbl);
            this.Controls.Add(this.CameraNameLbl);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.TallyLightRemoveBtn);
            this.Controls.Add(this.TallyLightAddBtn);
            this.Controls.Add(this.TallyLightCamListBox);
            this.Name = "TallyLightProd";
            this.Text = "TallyLightProd";
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
        private TextBox SceneNameTxt;
        private Label ServerLbl;
        private Label label3;
        private TextBox ServerTxt;
        private Button SetServerBtn;
        private Button StartBtn;
    }
}