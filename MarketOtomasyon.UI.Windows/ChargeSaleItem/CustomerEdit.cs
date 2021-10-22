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

namespace MarketOtomasyon.UI.Windows.ChargeSaleItem
{
    public partial class CustomerEdit : DevExpress.XtraEditors.XtraForm
    {
        int CustomerID = 0;

        public CustomerEdit(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
        }
        ICustomerService customerService = new CustomerService();

        private void btnSave_Click(object sender, EventArgs e)
        {
           Save();
        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            if (CustomerID > 0)

                LoadCustomer();
        }
        private void LoadCustomer()
        {

            var customersDto = customerService.GetById(CustomerID);
            if (customersDto != null)
            {
                txtCustomerName.Text = customersDto.NameSurname;
                txtCustomerAdress.Text = customersDto.Adress;
                txtCustomerPhone.Text = customersDto.Phone;
                txtCustomerWillGive.Text = customersDto.WillGive.ToString();

            }
        }
        private void Save()
        {
            CustomersDto customersDto = new CustomersDto();
            customersDto.NameSurname = txtCustomerName.Text;
            customersDto.Adress = txtCustomerAdress.Text;
            customersDto.Phone = txtCustomerPhone.Text;
            customersDto.WillGive = Convert.ToDecimal(txtCustomerWillGive.Text);
            try
            {
                if (CustomerID > 0)
                {
                    //Güncelleme işlemi gerçekleştirilir
                    customersDto.CustomerId = CustomerID;
                    customerService.Update(customersDto);
                }
                else
                {
                    //Insert işlemi gerçekleştirilir.
                    customerService.Add(customersDto);
                }

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