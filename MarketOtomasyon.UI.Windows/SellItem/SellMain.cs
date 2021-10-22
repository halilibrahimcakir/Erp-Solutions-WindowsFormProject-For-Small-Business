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

namespace MarketOtomasyon.UI.Windows.SellItem
{
    public partial class SellMain : Form
    {
        public SellMain()
        {
            InitializeComponent();
            lblProductPrice.Text = "0 TL";
            dataGridView1.AutoGenerateColumns = false;
            _list = new List<ProductsDto>();
        }
        List<ProductsDto> _list;
        List<ProductsDto> newList;
        DateTime dateTime = DateTime.Now;
        IPurchaseOrderService purchaseOrderServices = new PurchaseOrderService();
        IPurchaseOrderDetailService purchaseOrderDetailServices = new PurchaseOrderDetailService();
        ICustomerService customerServices = new CustomerService();
        IProductsService productsServices = new ProductsService();
        ICategoriesService categoriesService = new CategoriesService();

        public int ChangedCount { get; set; }
        public bool ChangedCountEdit { get; set; }
        private void btnCash_Click(object sender, EventArgs e)
        {
            SiparisTetikle(1, null);
            txtProducts.Focus();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (_list.Count > 0)
            {
                SiparisTetikle(2, null);
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün giriniz...");
            }
            txtProducts.Focus();
        }

        private void btnOnCredit_Click(object sender, EventArgs e)
        {
            OnCredit onCredit = new OnCredit();
            if (_list.Count > 0)
            {
                onCredit.ShowDialog();
                if (Cache.Operation == true)
                {
                    SiparisTetikle(3, onCredit.Customerid);
                    Cache.Operation = false;
                }

            }
            else
            {
                MessageBox.Show("Lütfen bir ürün giriniz...");
            }
            txtProducts.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _list.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txtProducts.Focus();
        }

        public void SiparisTetikle(int payment, int? customer)
        {
            if (_list.Count > 0)
            {
                PurchaseOrderDto purchaseOrderDto = new PurchaseOrderDto();
                purchaseOrderDto.EmployeeId = Cache.EmployeeId;
                purchaseOrderDto.PaymentTypeId = payment;
                purchaseOrderDto.IsApporeved = true;
                purchaseOrderDto.PurchasePrice = _list.Sum(p => p.InPrice);
                purchaseOrderDto.TotalPrice = _list.Sum(p => p.SalesPrice);
                purchaseOrderDto.CreateDate = dateTime;
                purchaseOrderDto.CreatedBy = Cache.EmployeeId;
                purchaseOrderDto.PurchaseOrderStatusId = 1;
                purchaseOrderDto.CustomerId = customer;
                purchaseOrderServices.Add(purchaseOrderDto);

                foreach (var item in _list)
                {
                    PurchaseOrderDetailDto purchaseOrderDetailDto = new PurchaseOrderDetailDto();
                    purchaseOrderDetailDto.PurchaseOrderId = purchaseOrderServices.GetAll().Max(p => p.PurchaseOrderId);
                    purchaseOrderDetailDto.ProductId = _list.Select(p => item.ProductId).FirstOrDefault();
                    purchaseOrderDetailDto.ProductName = _list.Select(p => item.ProductName).FirstOrDefault();
                    purchaseOrderDetailDto.Price = _list.Select(p => item.SalesPrice.Value / item.Count).FirstOrDefault();
                    purchaseOrderDetailDto.Quantity = _list.Select(p => item.Count).FirstOrDefault();
                    purchaseOrderDetailDto.CreatedBy = Cache.EmployeeId;
                    purchaseOrderDetailDto.CreatedDate = dateTime;
                    purchaseOrderDetailDto.QuantitySumPrice = purchaseOrderDetailDto.Price * purchaseOrderDetailDto.Quantity;
                    purchaseOrderDetailServices.Add(purchaseOrderDetailDto);

                    var stock = productsServices.GetById(purchaseOrderDetailDto.ProductId);
                    stock.StockCount -= purchaseOrderDetailDto.Quantity;
                    productsServices.Update(stock);

                }

                if (customer != null)
                {
                    CustomersDto customersDto = new CustomersDto();
                    var borc = (from p in customerServices.GetAll()
                                select p).Where(c => c.CustomerId == customer).FirstOrDefault();

                    customersDto.Adress = borc.Adress;
                    customersDto.NameSurname = borc.NameSurname;
                    customersDto.Phone = borc.Phone;
                    customersDto.WillGive = borc.WillGive.GetValueOrDefault() + purchaseOrderDto.TotalPrice;
                    customersDto.CustomerId = customer.Value;
                    customerServices.Update(customersDto);

                }
                _list.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                lblProductPrice.Text = "0 TL";

            }
            else
            {
                MessageBox.Show("Lütfen bir ürün giriniz...");

            }

        }

        public async Task Siparis()
        {

            newList = new List<ProductsDto>();
            newList.AddRange(_list);


            async Task<bool> UserKeepsTyping()
            {

                string txt = txtProducts.Text;
                await Task.Delay(500);
                return txt != txtProducts.Text;

            }
            if (await UserKeepsTyping()) return;

            var urun = (from p in productsServices.GetAll()
                        join c in categoriesService.GetAll() on p.CategoryId equals c.CategoryId
                        select new ProductsDto
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            CategoryName = c.CategoryName,
                            Count = p.Count,
                            SalesPrice = p.SalesPrice,
                            InPrice = p.InPrice

                        }).Where(p => p.ProductId.ToString() == txtProducts.Text).FirstOrDefault();

            if (urun != null)
            {

                if (_list.Where(p => p.ProductId == int.Parse(txtProducts.Text)).Count() > 0)
                {

                    var varOlanUrun = _list.Where(p => p.ProductId == int.Parse(txtProducts.Text)).FirstOrDefault();
                    if (ChangedCountEdit == true)
                    {
                        varOlanUrun.SalesPrice = urun.SalesPrice * varOlanUrun.Count;
                        varOlanUrun.Count += urun.Count - 1;
                        _list.RemoveAll(p => p.ProductId == int.Parse(txtProducts.Text));
                        newList.RemoveAll(p => p.ProductId == int.Parse(txtProducts.Text));
                        _list.Add(varOlanUrun);
                        newList.Add(varOlanUrun);
                        ChangedCountEdit = false;
                    }
                    else
                    {
                        varOlanUrun.SalesPrice += urun.SalesPrice;
                        varOlanUrun.Count += urun.Count;
                        _list.RemoveAll(p => p.ProductId == int.Parse(txtProducts.Text));
                        newList.RemoveAll(p => p.ProductId == int.Parse(txtProducts.Text));
                        _list.Add(varOlanUrun);
                        newList.Add(varOlanUrun);
                    }
                }
                else
                {
                    _list.Add(urun);
                    newList.Add(urun);
                }
                dataGridView1.DataSource = newList;
                lblProductPrice.Text = _list.Sum(p => p.SalesPrice).ToString();
                txtProducts.Clear();
            }
            else
            {
                txtProducts.Clear();
            }

        }

        private void txtProducts_TextChanged(object sender, EventArgs e)
        {
            txtProducts.Focus();
            if (System.Text.RegularExpressions.Regex.IsMatch(txtProducts.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ID'si giriniz.");
                txtProducts.Text = "";
            }
            else
            {
                Siparis();
            }
        }

        private void SellMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnCash.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnCredit.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                btnOnCredit.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnCancel.PerformClick();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Count")
            {
                int changedCount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Count"].Value);
                int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value);
                ChangedCount = changedCount;
                ChangedCountEdit = true;
                txtProducts.Text = productId.ToString();
            }
        }
    }
}
