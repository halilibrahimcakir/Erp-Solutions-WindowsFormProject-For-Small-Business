using MarketOtomasyon.Service.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyon.UI.Windows.ChargeSaleItem
{
    public partial class ChargeSaleMain : Form
    {
        int CustomerID = 0;
        public ChargeSaleMain()
        {
            InitializeComponent();
        }
        ICustomerService customerService = new CustomerService();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.ShowDialog();
            LoadCustomer();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                CustomerEdit(CustomerID);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                CustomerDelete(CustomerID);
            }
        }
        private void ChargeSaleMain_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            dataGridView1.DataSource = customerService.GetAll().ToList();
        }

        private void CustomerDelete(int customerID)
        {
            DialogResult dialogResult = MessageBox.Show(customerID + " id'li kategori silinecek! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    customerService.Delete(CustomerID);

                    //Silme işlemi tamamlandıktan sonra listeyi güncelliyoruz.
                    LoadCustomer();

                    MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
        }
        private void CustomerEdit(int customerID)
        {
            CustomerEdit customerEdit = new CustomerEdit(customerID);
            customerEdit.ShowDialog();
            LoadCustomer();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
                int customerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Customer"].Value);
                CustomerID = customerID;
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int customerID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["Customer"].Value);
                CustomerEdit(customerID);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerService.GetAll().Where(p => p.NameSurname.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
        }
    }
}
