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

namespace MarketOtomasyon.UI.Windows.ChargeSaleItem
{
    public partial class NewCustomer : DevExpress.XtraEditors.XtraForm
    {
      

        public NewCustomer()
        {
            InitializeComponent();
        }
        ICustomerService customerService = new CustomerService();

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomersDto customersDto = new CustomersDto();
            customersDto.NameSurname = txtCustomerName.Text;
            customersDto.Adress = txtCustomerAdress.Text;
            customersDto.Phone = txtCustomerPhone.Text;
            customersDto.IsActive = true;
            customersDto.CreatedBy = Cache.EmployeeId;
            customersDto.CreateDate = DateTime.Now;
            try
            {
                customerService.Add(customersDto);
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