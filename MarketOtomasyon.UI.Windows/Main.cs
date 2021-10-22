using DevExpress.XtraEditors;
using MarketOtomasyon.UI.Windows.AdminItem;
using MarketOtomasyon.UI.Windows.CacheManager;
using MarketOtomasyon.UI.Windows.CaseItem;
using MarketOtomasyon.UI.Windows.ChargeSaleItem;
using MarketOtomasyon.UI.Windows.ProductItem;
using MarketOtomasyon.UI.Windows.SellItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyon.UI.Windows
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void SellItem_ItemClick(object sender, TileItemEventArgs e)
        {
            openChildForm(new SellMain());
        }

        private void CaseItem_ItemClick(object sender, TileItemEventArgs e)
        {
            openChildForm(new CaseMain());
        }

        private void ProductsItem_ItemClick(object sender, TileItemEventArgs e)
        {
            openChildForm(new ProductMain());

        }

        private void AdminItem_ItemClick(object sender, TileItemEventArgs e)
        {
            openChildForm(new AdminMain());

        }

        private void ChargeSale_ItemClick(object sender, TileItemEventArgs e)
        {
            openChildForm(new ChargeSaleMain());

        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Cache.NameSurname.ToString();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}