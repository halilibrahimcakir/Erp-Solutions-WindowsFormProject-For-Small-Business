
namespace MarketOtomasyon.UI.Windows.ChargeSaleItem
{
    partial class CustomerEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEdit));
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lblVeresiyeAdress = new DevExpress.XtraEditors.LabelControl();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.lblWillGive = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCustomerWillGive = new System.Windows.Forms.TextBox();
            this.txtCustomerAdress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Appearance.Options.UseFont = true;
            this.lblCustomerName.Location = new System.Drawing.Point(23, 16);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(94, 18);
            this.lblCustomerName.TabIndex = 12;
            this.lblCustomerName.Text = "Veresiye Adı";
            // 
            // lblVeresiyeAdress
            // 
            this.lblVeresiyeAdress.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeresiyeAdress.Appearance.Options.UseFont = true;
            this.lblVeresiyeAdress.Location = new System.Drawing.Point(25, 82);
            this.lblVeresiyeAdress.Name = "lblVeresiyeAdress";
            this.lblVeresiyeAdress.Size = new System.Drawing.Size(51, 18);
            this.lblVeresiyeAdress.TabIndex = 11;
            this.lblVeresiyeAdress.Text = "Adress";
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 155);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 18);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Telefon";
            // 
            // lblWillGive
            // 
            this.lblWillGive.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWillGive.Appearance.Options.UseFont = true;
            this.lblWillGive.Location = new System.Drawing.Point(25, 228);
            this.lblWillGive.Name = "lblWillGive";
            this.lblWillGive.Size = new System.Drawing.Size(92, 18);
            this.lblWillGive.TabIndex = 9;
            this.lblWillGive.Text = "Borç Miktarı";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(119, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 53);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Değişikliği\r\nKaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomerWillGive
            // 
            this.txtCustomerWillGive.Location = new System.Drawing.Point(162, 225);
            this.txtCustomerWillGive.Name = "txtCustomerWillGive";
            this.txtCustomerWillGive.Size = new System.Drawing.Size(168, 21);
            this.txtCustomerWillGive.TabIndex = 19;
            // 
            // txtCustomerAdress
            // 
            this.txtCustomerAdress.Location = new System.Drawing.Point(162, 83);
            this.txtCustomerAdress.Name = "txtCustomerAdress";
            this.txtCustomerAdress.Size = new System.Drawing.Size(168, 21);
            this.txtCustomerAdress.TabIndex = 20;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(162, 17);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(168, 21);
            this.txtCustomerName.TabIndex = 21;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(162, 152);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(168, 21);
            this.txtCustomerPhone.TabIndex = 22;
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 366);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerAdress);
            this.Controls.Add(this.txtCustomerWillGive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblVeresiyeAdress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblWillGive);
            this.IconOptions.Image = global::MarketOtomasyon.UI.Windows.Properties.Resources.main_logo;
            this.Name = "CustomerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerEdit";
            this.Load += new System.EventHandler(this.CustomerEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private DevExpress.XtraEditors.LabelControl lblVeresiyeAdress;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.LabelControl lblWillGive;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtCustomerWillGive;
        private System.Windows.Forms.TextBox txtCustomerAdress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhone;
    }
}