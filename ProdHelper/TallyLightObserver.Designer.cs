namespace ProdHelper
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ServerLbl = new System.Windows.Forms.Label();
            this.CamerNameLbl = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(103, 75);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(183, 23);
            this.ApplyBtn.TabIndex = 0;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 23);
            this.textBox2.TabIndex = 2;
            // 
            // ServerLbl
            // 
            this.ServerLbl.AutoSize = true;
            this.ServerLbl.Location = new System.Drawing.Point(55, 20);
            this.ServerLbl.Name = "ServerLbl";
            this.ServerLbl.Size = new System.Drawing.Size(42, 15);
            this.ServerLbl.TabIndex = 4;
            this.ServerLbl.Text = "Server:";
            // 
            // CamerNameLbl
            // 
            this.CamerNameLbl.AutoSize = true;
            this.CamerNameLbl.Location = new System.Drawing.Point(11, 49);
            this.CamerNameLbl.Name = "CamerNameLbl";
            this.CamerNameLbl.Size = new System.Drawing.Size(86, 15);
            this.CamerNameLbl.TabIndex = 5;
            this.CamerNameLbl.Text = "Camera Name:";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 140);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(274, 60);
            this.OpenBtn.TabIndex = 6;
            this.OpenBtn.Text = "Open New Window";
            this.OpenBtn.UseVisualStyleBackColor = true;
            // 
            // TallyLightObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 212);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.CamerNameLbl);
            this.Controls.Add(this.ServerLbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ApplyBtn);
            this.Name = "TallyLightObserver";
            this.Text = "Tally Light (Observer)";
            this.Load += new System.EventHandler(this.TallyLightObserver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ApplyBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label ServerLbl;
        private Label CamerNameLbl;
        private Button OpenBtn;
    }
}