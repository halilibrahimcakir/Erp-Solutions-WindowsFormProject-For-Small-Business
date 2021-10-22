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

namespace MarketOtomasyon.UI.Windows.AdminItem
{
    public partial class AdminMain : Form
    {
        int EmployeeID = 0;
        public AdminMain()
        {
            InitializeComponent();
        }
        private void LoadList()
        {
            dataGridView1.DataSource = employeeService.GetAll();
        }
        IEmployeeService employeeService = new EmployeeService();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeService.GetAll().Where(p => p.NameSurname.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int employeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EmployeeId"].Value);
            EmployeeID = employeeID;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int employeeID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["EmployeeId"].Value);
                EmployeeEdit(employeeID);
            }
        }

        private void EmployeeEdit(int employeeID)
        {
            EmployeeEdit employeeEdit = new EmployeeEdit(employeeID);
            employeeEdit.ShowDialog();
            LoadList();
        }

        private void EmployeeDelete(int employeeID)
        {
            DialogResult dialogResult = MessageBox.Show(employeeID + " id'li kategori silinecek! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    employeeService.Delete(employeeID);
                    LoadList();

                    MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.ShowDialog();
            LoadList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EmployeeEdit(EmployeeID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                EmployeeDelete(EmployeeID);
            }
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadList();
        }
    }
}
