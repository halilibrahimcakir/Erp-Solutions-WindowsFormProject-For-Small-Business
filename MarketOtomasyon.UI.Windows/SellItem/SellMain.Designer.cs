
namespace MarketOtomasyon.UI.Windows.SellItem
{
    partial class SellMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnCredit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCredit = new DevExpress.XtraEditors.SimpleButton();
            this.btnCash = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.separatorControl2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.separatorControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 591);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.CategoryName,
            this.Count,
            this.SalesPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(113, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(670, 497);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Ürün Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Ürün Adı";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Categori Adı";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Adet";
            this.Count.Name = "Count";
            // 
            // SalesPrice
            // 
            this.SalesPrice.DataPropertyName = "SalesPrice";
            this.SalesPrice.HeaderText = "Fiyat";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl2.Location = new System.Drawing.Point(113, 72);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(670, 22);
            this.separatorControl2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtProducts);
            this.panel4.Controls.Add(this.lblProductPrice);
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Controls.Add(this.labelControl2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(113, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 72);
            this.panel4.TabIndex = 8;
            // 
            // txtProducts
            // 
            this.txtProducts.Location = new System.Drawing.Point(223, 24);
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(168, 20);
            this.txtProducts.TabIndex = 3;
            this.txtProducts.TextChanged += new System.EventHandler(this.txtProducts_TextChanged);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPrice.Appearance.Options.UseFont = true;
            this.lblProductPrice.Location = new System.Drawing.Point(517, 23);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(10, 18);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(435, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "TUTAR";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(169, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ürün Barkod Numarası";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(87, 0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(26, 591);
            this.separatorControl1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOnCredit);
            this.panel2.Controls.Add(this.btnCredit);
            this.panel2.Controls.Add(this.btnCash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 591);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseTextOptions = true;
            this.btnCancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(5, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCancel.Size = new System.Drawing.Size(74, 69);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İptal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOnCredit
            // 
            this.btnOnCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOnCredit.Appearance.Options.UseFont = true;
            this.btnOnCredit.Appearance.Options.UseTextOptions = true;
            this.btnOnCredit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnOnCredit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btnOnCredit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnOnCredit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOnCredit.ImageOptions.SvgImage")));
            this.btnOnCredit.Location = new System.Drawing.Point(5, 233);
            this.btnOnCredit.Name = "btnOnCredit";
            this.btnOnCredit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOnCredit.Size = new System.Drawing.Size(74, 69);
            this.btnOnCredit.TabIndex = 1;
            this.btnOnCredit.Text = "F3\r\nVeresiye";
            this.btnOnCredit.Click += new System.EventHandler(this.btnOnCredit_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCredit.Appearance.Options.UseFont = true;
            this.btnCredit.Appearance.Options.UseTextOptions = true;
            this.btnCredit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCredit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btnCredit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCredit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCredit.ImageOptions.SvgImage")));
            this.btnCredit.Location = new System.Drawing.Point(5, 118);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCredit.Size = new System.Drawing.Size(74, 69);
            this.btnCredit.TabIndex = 1;
            this.btnCredit.Text = "F2\r\nKredi Kartı";
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCash.Appearance.Options.UseFont = true;
            this.btnCash.Appearance.Options.UseTextOptions = true;
            this.btnCash.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnCash.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btnCash.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.ImageOptions.Image")));
            this.btnCash.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnCash.Location = new System.Drawing.Point(5, 3);
            this.btnCash.Name = "btnCash";
            this.btnCash.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCash.Size = new System.Drawing.Size(74, 69);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "F1\r\nPEŞİN SATIŞ";
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // SellMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 591);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SellMain";
            this.Text = "SellMain";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SellMain_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOnCredit;
        private DevExpress.XtraEditors.SimpleButton btnCredit;
        private DevExpress.XtraEditors.SimpleButton btnCash;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtProducts;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private DevExpress.XtraEditors.LabelControl lblProductPrice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}