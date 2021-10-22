
namespace MarketOtomasyon.UI.Windows.AdminItem
{
    partial class EmployeeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeEdit));
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblNameSurname = new DevExpress.XtraEditors.LabelControl();
            this.lblUsername = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.lblAdress = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(173, 313);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(168, 21);
            this.txtAdress.TabIndex = 36;

            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(173, 241);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 21);
            this.txtPhone.TabIndex = 35;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 21);
            this.txtPassword.TabIndex = 34;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(173, 25);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(168, 21);
            this.txtNameSurname.TabIndex = 33;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(147, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 53);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Değişikliği\r\nKaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.Appearance.Options.UseFont = true;
            this.lblNameSurname.Location = new System.Drawing.Point(32, 28);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(83, 18);
            this.lblNameSurname.TabIndex = 31;
            this.lblNameSurname.Text = "Çalışan Adı";
            // 
            // lblUsername
            // 
            this.lblUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Appearance.Options.UseFont = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 18);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Kullanıcı Adı";

            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 172);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 18);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Şifresi";
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 244);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(132, 18);
            this.lblPhone.TabIndex = 28;
            this.lblPhone.Text = "Telefon Numarası";
            // 
            // lblAdress
            // 
            this.lblAdress.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdress.Appearance.Options.UseFont = true;
            this.lblAdress.Location = new System.Drawing.Point(32, 316);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(43, 18);
            this.lblAdress.TabIndex = 27;
            this.lblAdress.Text = "Adres";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(173, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(168, 21);
            this.txtUserName.TabIndex = 37;
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 446);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAdress);
            this.IconOptions.Image = global::MarketOtomasyon.UI.Windows.Properties.Resources.main_logo;
            this.Name = "EmployeeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeEdit";
            this.Load += new System.EventHandler(this.EmployeeEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNameSurname;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblNameSurname;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.LabelControl lblAdress;
        private System.Windows.Forms.TextBox txtUserName;
    }
}