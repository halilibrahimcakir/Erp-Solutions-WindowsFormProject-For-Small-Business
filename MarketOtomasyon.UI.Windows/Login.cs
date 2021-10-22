using DevExpress.XtraEditors;
using MarketOtomasyon.Dto.Dto;
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

namespace MarketOtomasyon.UI.Windows
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IEmployeeService employeesServices = new EmployeeService();
            var login = (from emp in employeesServices.GetAll().Where(p => p.Username == txtId.Text && p.Password == txtPw.Text)
                         select new EmployeeDto
                         {
                             Username = emp.Username,
                             Password = emp.Password,
                             NameSurname = emp.NameSurname,
                             EmployeeId = emp.EmployeeId

                         }).FirstOrDefault();

            if (login != null)
            {
                Cache.NameSurname = login.NameSurname;
                Cache.EmployeeId = login.EmployeeId;
                Main mainform = new Main();
                Hide();
                mainform.Show();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girildi...");
            }
        }
    }
}