
namespace MarketOtomasyon.UI.Windows
{
    partial class Login
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(515, 101);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 21);
            this.txtId.TabIndex = 10;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(515, 147);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(135, 21);
            this.txtPw.TabIndex = 11;
            this.txtPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AllowDrop = true;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(391, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 26);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Şifre";
            // 
            // lblId
            // 
            this.lblId.AllowDrop = true;
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(370, 95);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(124, 32);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Kullanıcı Adı ";
            this.lblId.UseCompatibleTextRendering = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(545, 198);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarketOtomasyon.UI.Windows.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(148, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 308);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.Image = global::MarketOtomasyon.UI.Windows.Properties.Resources.main_logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblId;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}