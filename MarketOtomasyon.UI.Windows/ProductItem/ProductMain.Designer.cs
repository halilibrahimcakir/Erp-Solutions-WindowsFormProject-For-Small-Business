
namespace MarketOtomasyon.UI.Windows.ProductItem
{
    partial class ProductMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblProduct = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductAdd = new DevExpress.XtraEditors.SimpleButton();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dataGridView1);
            this.pnlMain.Controls.Add(this.separatorControl2);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.separatorControl1);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.ProductName,
            this.CategoryId,
            this.StockCount,
            this.InPrice,
            this.SalesPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(113, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(687, 356);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // separatorControl2
            // 
            this.separatorControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl2.Location = new System.Drawing.Point(113, 72);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(687, 22);
            this.separatorControl2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.lblProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(113, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 72);
            this.panel4.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(110, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.Appearance.Options.UseFont = true;
            this.lblProduct.Location = new System.Drawing.Point(19, 25);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(68, 18);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Ürün Adı ";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(87, 0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(26, 450);
            this.separatorControl1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnProductAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 450);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseTextOptions = true;
            this.btnDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnDelete.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(5, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDelete.Size = new System.Drawing.Size(74, 69);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Appearance.Options.UseTextOptions = true;
            this.btnEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnEdit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(5, 132);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEdit.Size = new System.Drawing.Size(74, 69);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnProductAdd.Appearance.Options.UseFont = true;
            this.btnProductAdd.Appearance.Options.UseTextOptions = true;
            this.btnProductAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnProductAdd.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btnProductAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnProductAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProductAdd.ImageOptions.SvgImage")));
            this.btnProductAdd.Location = new System.Drawing.Point(5, 23);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnProductAdd.Size = new System.Drawing.Size(74, 69);
            this.btnProductAdd.TabIndex = 1;
            this.btnProductAdd.Text = "Ürün Ekle";
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // Product
            // 
            this.Product.DataPropertyName = "ProductId";
            this.Product.HeaderText = "Ürün Id";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Ürün Adı";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryName";
            this.CategoryId.HeaderText = "CategoryName";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            // 
            // StockCount
            // 
            this.StockCount.DataPropertyName = "StockCount";
            this.StockCount.HeaderText = "Stok Adeti";
            this.StockCount.Name = "StockCount";
            this.StockCount.ReadOnly = true;
            // 
            // InPrice
            // 
            this.InPrice.DataPropertyName = "InPrice";
            this.InPrice.HeaderText = "Geliş Fiyatı";
            this.InPrice.Name = "InPrice";
            this.InPrice.ReadOnly = true;
            // 
            // SalesPrice
            // 
            this.SalesPrice.DataPropertyName = "SalesPrice";
            this.SalesPrice.HeaderText = "Satış Fiyatı";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            // 
            // ProductMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductMain";
            this.Text = "ProductMain";
            this.Load += new System.EventHandler(this.ProductMain_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.LabelControl lblProduct;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnProductAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
    }
}