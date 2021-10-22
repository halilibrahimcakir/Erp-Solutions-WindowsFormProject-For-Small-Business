using DevExpress.XtraEditors;
using MarketOtomasyon.Dto.Dto;
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
    public partial class NewEmployee : DevExpress.XtraEditors.XtraForm
    {
        public NewEmployee()
        {
            InitializeComponent();
        }
        IEmployeeService employeeService = new EmployeeService();

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeDto employeeDto = new EmployeeDto();
            employeeDto.NameSurname = txtNameSurname.Text;
            employeeDto.Username = txtUserName.Text;
            employeeDto.Password = txtPassword.Text;
            employeeDto.Phone = txtPhone.Text;
            employeeDto.Adress = txtAdress.Text;

            try
            {

                employeeService.Add(employeeDto);
                MessageBox.Show("Kaydetme işlemi başarıyla tamamlandı...");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu! Hata detayı: \r\n" + ex.Message);
            }
        }
    }
}