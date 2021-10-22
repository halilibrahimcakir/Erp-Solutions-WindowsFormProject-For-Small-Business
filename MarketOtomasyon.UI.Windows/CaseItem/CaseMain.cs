using MarketOtomasyon.Service.Service;
using MarketOtomasyon.UI.Windows.CacheManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyon.UI.Windows.CaseItem
{
    public partial class CaseMain : Form
    {
        public CaseMain()
        {
            InitializeComponent();
        }
        IPurchaseOrderService purchaseOrderService = new PurchaseOrderService();

        private void LoadOrder()
        {
            var sorgu = purchaseOrderService.GetAll().Where(p => p.CreateDate > dTStart.Value && p.CreateDate < dTFinish.Value).ToList();

            dataGridView1.DataSource = sorgu;
        }

        private void CaseMain_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dTStart.Value = new DateTime(
             dTStart.Value.Year,
             dTStart.Value.Month,
             dTStart.Value.Day, 0, 0, 0);
            dTFinish.Value = new DateTime(
             dTFinish.Value.Year,
             dTFinish.Value.Month,
             dTFinish.Value.Day, 23, 59, 59);
            LoadOrder();
        }

        private void dTStart_ValueChanged(object sender, EventArgs e)
        {
            var sorgu = purchaseOrderService.GetAll().Where(p => p.CreateDate > dTStart.Value && p.CreateDate < dTFinish.Value && p.PurchaseOrderStatusId == 1).ToList();
            dataGridView1.DataSource = sorgu;
        }

        private void dTFınish_ValueChanged(object sender, EventArgs e)
        {
            var sorgu = purchaseOrderService.GetAll().Where(p => p.CreateDate > dTStart.Value && p.CreateDate < dTFinish.Value && p.PurchaseOrderStatusId == 1).ToList();
            dataGridView1.DataSource = sorgu;
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int orderID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                decimal totalprice = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value);
                OrderEdit(orderID, totalprice);
                Cache.Operation = false;
                LoadOrder();
            }
            else
            {
                MessageBox.Show("İlk önce bir sipariş seçmelisiniz...");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PurchaseOrderId"].Value);
            decimal totalprice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["TotalPrice"].Value);
            if (e.RowIndex >= 0)
            {
                OrderEdit(orderID, totalprice);

            }
        }

        private void OrderEdit(int orderID, decimal totalprice)
        {
            CaseEdit caseEdit = new CaseEdit(orderID, totalprice);
            caseEdit.ShowDialog();
            Cache.Operation = false;
            LoadOrder();
        }



    }
}
