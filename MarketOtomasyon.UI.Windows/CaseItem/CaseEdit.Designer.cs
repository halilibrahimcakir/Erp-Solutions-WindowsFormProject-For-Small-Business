
namespace MarketOtomasyon.UI.Windows.CaseItem
{
    partial class CaseEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefund = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.bntDropPiece = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PurchaseOrderDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantitySumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrderTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblOrder = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRefund);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.bntDropPiece);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 517);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(415, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 53);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Siparişi\r\nKaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefund.Appearance.Options.UseFont = true;
            this.btnRefund.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefund.ImageOptions.Image")));
            this.btnRefund.Location = new System.Drawing.Point(278, 447);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(91, 53);
            this.btnRefund.TabIndex = 15;
            this.btnRefund.Text = "Tüm\r\nŞiparişi\r\nİade Et\r\n";
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(141, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 53);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Ürünü \r\nSil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bntDropPiece
            // 
            this.bntDropPiece.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bntDropPiece.Appearance.Options.UseFont = true;
            this.bntDropPiece.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntDropPiece.ImageOptions.Image")));
            this.bntDropPiece.Location = new System.Drawing.Point(4, 447);
            this.bntDropPiece.Name = "bntDropPiece";
            this.bntDropPiece.Size = new System.Drawing.Size(91, 53);
            this.bntDropPiece.TabIndex = 15;
            this.bntDropPiece.Text = "Adet\r\nDüşür";
            this.bntDropPiece.Click += new System.EventHandler(this.bntDropPiece_Click);
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
            this.PurchaseOrderDetailId,
            this.ProductId,
            this.ProductName,
            this.Quantity,
            this.QuantitySumPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(509, 318);
            this.dataGridView1.TabIndex = 14;
            // 
            // PurchaseOrderDetailId
            // 
            this.PurchaseOrderDetailId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PurchaseOrderDetailId.DataPropertyName = "PurchaseOrderDetailId";
            this.PurchaseOrderDetailId.HeaderText = "Sipariş Detay Id";
            this.PurchaseOrderDetailId.Name = "PurchaseOrderDetailId";
            this.PurchaseOrderDetailId.ReadOnly = true;
            this.PurchaseOrderDetailId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PurchaseOrderDetailId.Width = 89;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Ürün Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ProductId.Width = 88;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Ürün Adı";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ProductName.Width = 89;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Ürün Adeti";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Quantity.Width = 88;
            // 
            // QuantitySumPrice
            // 
            this.QuantitySumPrice.DataPropertyName = "QuantitySumPrice";
            this.QuantitySumPrice.HeaderText = "Ürün Fiyatı";
            this.QuantitySumPrice.Name = "QuantitySumPrice";
            this.QuantitySumPrice.ReadOnly = true;
            this.QuantitySumPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOrderTotalPrice);
            this.panel2.Controls.Add(this.lblOrderID);
            this.panel2.Controls.Add(this.lblOrderPrice);
            this.panel2.Controls.Add(this.lblOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 109);
            this.panel2.TabIndex = 0;
            // 
            // lblOrderTotalPrice
            // 
            this.lblOrderTotalPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderTotalPrice.Appearance.Options.UseFont = true;
            this.lblOrderTotalPrice.Location = new System.Drawing.Point(192, 63);
            this.lblOrderTotalPrice.Name = "lblOrderTotalPrice";
            this.lblOrderTotalPrice.Size = new System.Drawing.Size(140, 18);
            this.lblOrderTotalPrice.TabIndex = 3;
            this.lblOrderTotalPrice.Text = "lblOrderTotalPrice";
            // 
            // lblOrderID
            // 
            this.lblOrderID.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderID.Appearance.Options.UseFont = true;
            this.lblOrderID.Location = new System.Drawing.Point(192, 21);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(81, 18);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "lblOrderID";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderPrice.Appearance.Options.UseFont = true;
            this.lblOrderPrice.Location = new System.Drawing.Point(60, 63);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(111, 18);
            this.lblOrderPrice.TabIndex = 3;
            this.lblOrderPrice.Text = "Sipariş Tutarı :";
            // 
            // lblOrder
            // 
            this.lblOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrder.Appearance.Options.UseFont = true;
            this.lblOrder.Location = new System.Drawing.Point(60, 21);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(84, 18);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "Sipariş ID :";
            // 
            // CaseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 517);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = global::MarketOtomasyon.UI.Windows.Properties.Resources.main_logo;
            this.Name = "CaseEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaseEdit";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CaseEdit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnRefund;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton bntDropPiece;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantitySumPrice;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblOrderTotalPrice;
        private DevExpress.XtraEditors.LabelControl lblOrderID;
        private DevExpress.XtraEditors.LabelControl lblOrderPrice;
        private DevExpress.XtraEditors.LabelControl lblOrder;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}