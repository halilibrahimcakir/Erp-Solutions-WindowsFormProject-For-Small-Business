
namespace MarketOtomasyon.UI.Windows
{
    partial class Main
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
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.SellItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.CaseItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.ChargeSale = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.ProductsItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.AdminItem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new DevExpress.XtraEditors.LabelControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 60;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 7;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectedItem = this.SellItem;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1348, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.SellItem);
            this.tileBarGroupTables.Items.Add(this.CaseItem);
            this.tileBarGroupTables.Items.Add(this.ChargeSale);
            this.tileBarGroupTables.Items.Add(this.ProductsItem);
            this.tileBarGroupTables.Items.Add(this.AdminItem);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            // 
            // SellItem
            // 
            this.SellItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.SellItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.SellItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement6.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.SingleBorder;
            tileItemElement6.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement6.Text = "Satış İşlemleri";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.SellItem.Elements.Add(tileItemElement6);
            this.SellItem.Name = "SellItem";
            this.SellItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.SellItem_ItemClick);
            // 
            // CaseItem
            // 
            this.CaseItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement7.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            tileItemElement7.Text = "Kasa";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.CaseItem.Elements.Add(tileItemElement7);
            this.CaseItem.Id = 2;
            this.CaseItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.CaseItem.Name = "CaseItem";
            this.CaseItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.CaseItem_ItemClick);
            // 
            // ChargeSale
            // 
            this.ChargeSale.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement8.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            tileItemElement8.Text = "Veresiye";
            this.ChargeSale.Elements.Add(tileItemElement8);
            this.ChargeSale.Id = 6;
            this.ChargeSale.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.ChargeSale.Name = "ChargeSale";
            this.ChargeSale.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ChargeSale_ItemClick);
            // 
            // ProductsItem
            // 
            this.ProductsItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement9.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
            tileItemElement9.Text = "Ürün Yönetimi";
            this.ProductsItem.Elements.Add(tileItemElement9);
            this.ProductsItem.Id = 3;
            this.ProductsItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.ProductsItem.Name = "ProductsItem";
            this.ProductsItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.ProductsItem_ItemClick);
            // 
            // AdminItem
            // 
            this.AdminItem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
            tileItemElement10.Text = "Yönetici İşlemleri";
            this.AdminItem.Elements.Add(tileItemElement10);
            this.AdminItem.Id = 4;
            this.AdminItem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.AdminItem.Name = "AdminItem";
            this.AdminItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.AdminItem_ItemClick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 110);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1348, 538);
            this.pnlMain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarketOtomasyon.UI.Windows.Properties.Resources.childform_logo;
            this.pictureBox1.Location = new System.Drawing.Point(301, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUser.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Appearance.Options.UseBackColor = true;
            this.lblUser.Appearance.Options.UseFont = true;
            this.lblUser.Appearance.Options.UseForeColor = true;
            this.lblUser.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblUser.Location = new System.Drawing.Point(1081, 44);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 18);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Kullanıcı :";
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Appearance.Options.UseBackColor = true;
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.Appearance.Options.UseForeColor = true;
            this.lblUserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblUserName.Location = new System.Drawing.Point(1173, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(97, 18);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "lblUserName";
            // 
            // Main
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 648);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tileBar);
            this.IconOptions.Image = global::MarketOtomasyon.UI.Windows.Properties.Resources.main_logo;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Otomasyon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem SellItem;
        private DevExpress.XtraBars.Navigation.TileBarItem CaseItem;
        private DevExpress.XtraBars.Navigation.TileBarItem ProductsItem;
        private DevExpress.XtraBars.Navigation.TileBarItem AdminItem;
        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraBars.Navigation.TileBarItem ChargeSale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblUser;
        private DevExpress.XtraEditors.LabelControl lblUserName;
    }
}