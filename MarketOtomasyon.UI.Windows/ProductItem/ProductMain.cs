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

namespace MarketOtomasyon.UI.Windows.ProductItem
{
    public partial class ProductMain : Form
    {
        int ProductID = 0;
        public ProductMain()
        {
            InitializeComponent();
        }
        IProductsService productsService = new ProductsService();
        ICategoriesService categoriesService = new CategoriesService();

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            newProduct.ShowDialog();
            LoadProduct();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                ProductEdit(ProductID);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                ProductDelete(ProductID);
            }
        }

        private void ProductMain_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadProduct();
        }
        private void LoadProduct()
        {
            var sorgu = (from p in productsService.GetAll()
                         join c in categoriesService.GetAll() on p.CategoryId equals c.CategoryId
                         select new ProductsDto
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             CategoryName = c.CategoryName,
                             StockCount = p.StockCount,
                             InPrice = p.InPrice,
                             SalesPrice = p.SalesPrice,
                             ExpirationDate = p.ExpirationDate,
                             IsActive = p.IsActive,
                         }).ToList();
            var bindingList = new BindingList<ProductsDto>(sorgu);
            dataGridView1.DataSource = bindingList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadProduct();
            }
            else
            {
                dataGridView1.DataSource = productsService.GetAll().Where(p => p.ProductName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["Product"].Value);
                ProductID = productId;
                ProductEdit(ProductID);

            }
        }
        private void ProductEdit(int ProductID)
        {
            ProductEdit productEdit = new ProductEdit(ProductID);
            productEdit.ShowDialog();
            LoadProduct();
        }

        private void ProductDelete(int ProductID)
        {
            DialogResult dialogResult = MessageBox.Show(ProductID + " id'li kategori silinecek! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    productsService.Delete(ProductID);

                    LoadProduct();

                    MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Product"].Value);
            ProductID = productId;
        }
    }
}
