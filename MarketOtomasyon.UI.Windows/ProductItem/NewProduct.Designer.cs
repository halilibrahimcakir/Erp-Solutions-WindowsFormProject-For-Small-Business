
namespace MarketOtomasyon.UI.Windows.ProductItem
{
    partial class NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            this.cmbProductCategories = new System.Windows.Forms.ComboBox();
            this.txtProductSalesPrice = new System.Windows.Forms.TextBox();
            this.txtProductInPrice = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.lblProductCategories = new DevExpress.XtraEditors.LabelControl();
            this.lblProductStock = new DevExpress.XtraEditors.LabelControl();
            this.lblProductInPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblProductSalesPrice = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cmbProductCategories
            // 
            this.cmbProductCategories.FormattingEnabled = true;
            this.cmbProductCategories.Location = new System.Drawing.Point(173, 108);
            this.cmbProductCategories.Name = "cmbProductCategories";
            this.cmbProductCategories.Size = new System.Drawing.Size(168, 21);
            this.cmbProductCategories.TabIndex = 37;
            // 
            // txtProductSalesPrice
            // 
            this.txtProductSalesPrice.Location = new System.Drawing.Point(173, 324);
            this.txtProductSalesPrice.Name = "txtProductSalesPrice";
            this.txtProductSalesPrice.Size = new System.Drawing.Size(168, 21);
            this.txtProductSalesPrice.TabIndex = 36;
            // 
            // txtProductInPrice
            // 
            this.txtProductInPrice.Location = new System.Drawing.Point(173, 252);
            this.txtProductInPrice.Name = "txtProductInPrice";
            this.txtProductInPrice.Size = new System.Drawing.Size(168, 21);
            this.txtProductInPrice.TabIndex = 35;
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(173, 184);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(168, 21);
            this.txtProductStock.TabIndex = 34;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(173, 40);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(168, 21);
            this.txtProductName.TabIndex = 33;
            // 
            // lblProductName
            // 
            this.lblProductName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Appearance.Options.UseFont = true;
            this.lblProductName.Location = new System.Drawing.Point(42, 39);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(68, 18);
            this.lblProductName.TabIndex = 31;
            this.lblProductName.Text = "Ürün Adı ";
            // 
            // lblProductCategories
            // 
            this.lblProductCategories.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCategories.Appearance.Options.UseFont = true;
            this.lblProductCategories.Location = new System.Drawing.Point(42, 111);
            this.lblProductCategories.Name = "lblProductCategories";
            this.lblProductCategories.Size = new System.Drawing.Size(117, 18);
            this.lblProductCategories.TabIndex = 30;
            this.lblProductCategories.Text = "Ürün Kategorisi";
            // 
            // lblProductStock
            // 
            this.lblProductStock.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductStock.Appearance.Options.UseFont = true;
            this.lblProductStock.Location = new System.Drawing.Point(42, 183);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(83, 18);
            this.lblProductStock.TabIndex = 29;
            this.lblProductStock.Text = "Ürün Stock";
            // 
            // lblProductInPrice
            // 
            this.lblProductInPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductInPrice.Appearance.Options.UseFont = true;
            this.lblProductInPrice.Location = new System.Drawing.Point(42, 255);
            this.lblProductInPrice.Name = "lblProductInPrice";
            this.lblProductInPrice.Size = new System.Drawing.Size(85, 18);
            this.lblProductInPrice.TabIndex = 28;
            this.lblProductInPrice.Text = "Geliş Fiyatı";
            // 
            // lblProductSalesPrice
            // 
            this.lblProductSalesPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductSalesPrice.Appearance.Options.UseFont = true;
            this.lblProductSalesPrice.Location = new System.Drawing.Point(42, 327);
            this.lblProductSalesPrice.Name = "lblProductSalesPrice";
            this.lblProductSalesPrice.Size = new System.Drawing.Size(85, 18);
            this.lblProductSalesPrice.TabIndex = 27;
            this.lblProductSalesPrice.Text = "Satış Fiyatı";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(147, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 53);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Değişikliği\r\nKaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 446);
            this.Controls.Add(this.cmbProductCategories);
            this.Controls.Add(this.txtProductSalesPrice);
            this.Controls.Add(this.txtProductInPrice);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCategories);
            this.Controls.Add(this.lblProductStock);
            this.Controls.Add(this.lblProductInPrice);
            this.Controls.Add(this.lblProductSalesPrice);
            this.IconOptions.Image = global::MarketOtomasyon.UI.Windows.Properties.Resources.main_logo;
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProduct";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductCategories;
        private System.Windows.Forms.TextBox txtProductSalesPrice;
        private System.Windows.Forms.TextBox txtProductInPrice;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.TextBox txtProductName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.LabelControl lblProductCategories;
        private DevExpress.XtraEditors.LabelControl lblProductStock;
        private DevExpress.XtraEditors.LabelControl lblProductInPrice;
        private DevExpress.XtraEditors.LabelControl lblProductSalesPrice;
    }
}