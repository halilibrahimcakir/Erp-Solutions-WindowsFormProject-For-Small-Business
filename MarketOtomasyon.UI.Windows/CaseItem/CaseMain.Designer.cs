
namespace MarketOtomasyon.UI.Windows.CaseItem
{
    partial class CaseMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PurchaseOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dTFinish = new System.Windows.Forms.DateTimePicker();
            this.dTStart = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefund = new DevExpress.XtraEditors.SimpleButton();
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
            this.pnlMain.Size = new System.Drawing.Size(835, 519);
            this.pnlMain.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseOrderId,
            this.CustomerId,
            this.EmployeeName,
            this.PaymentTypeId,
            this.TotalPrice,
            this.CreateDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(113, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(722, 425);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // PurchaseOrderId
            // 
            this.PurchaseOrderId.DataPropertyName = "PurchaseOrderId";
            this.PurchaseOrderId.HeaderText = "Sipariş Id";
            this.PurchaseOrderId.Name = "PurchaseOrderId";
            this.PurchaseOrderId.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "Müşteri Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeId";
            this.EmployeeName.HeaderText = "Siparişi Yapan Çalışan Id";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // PaymentTypeId
            // 
            this.PaymentTypeId.DataPropertyName = "PaymentTypeId";
            this.PaymentTypeId.HeaderText = "Ödeme Tipi";
            this.PaymentTypeId.Name = "PaymentTypeId";
            this.PaymentTypeId.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Toplam Fiyat";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Satış Tarihi";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl2.Location = new System.Drawing.Point(113, 72);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(722, 22);
            this.separatorControl2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dTFinish);
            this.panel4.Controls.Add(this.dTStart);
            this.panel4.Controls.Add(this.labelControl2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(113, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 72);
            this.panel4.TabIndex = 11;
            // 
            // dTFinish
            // 
            this.dTFinish.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dTFinish.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTFinish.Location = new System.Drawing.Point(359, 21);
            this.dTFinish.Name = "dTFinish";
            this.dTFinish.Size = new System.Drawing.Size(200, 22);
            this.dTFinish.TabIndex = 3;
            this.dTFinish.ValueChanged += new System.EventHandler(this.dTFınish_ValueChanged);
            // 
            // dTStart
            // 
            this.dTStart.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.dTStart.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dTStart.Location = new System.Drawing.Point(130, 21);
            this.dTStart.Name = "dTStart";
            this.dTStart.Size = new System.Drawing.Size(200, 22);
            this.dTStart.TabIndex = 3;
            this.dTStart.ValueChanged += new System.EventHandler(this.dTStart_ValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tarih Aralığı";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(87, 0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(26, 519);
            this.separatorControl1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefund);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 519);
            this.panel2.TabIndex = 2;
            // 
            // btnRefund
            // 
            this.btnRefund.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefund.Appearance.Options.UseFont = true;
            this.btnRefund.Appearance.Options.UseTextOptions = true;
            this.btnRefund.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnRefund.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btnRefund.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnRefund.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefund.ImageOptions.SvgImage")));
            this.btnRefund.Location = new System.Drawing.Point(5, 3);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnRefund.Size = new System.Drawing.Size(74, 69);
            this.btnRefund.TabIndex = 1;
            this.btnRefund.Text = "Geri İade";
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // CaseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 519);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaseMain";
            this.Text = "CaseMain";
            this.Load += new System.EventHandler(this.CaseMain_Load);
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
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnRefund;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dTFinish;
        private System.Windows.Forms.DateTimePicker dTStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }
}