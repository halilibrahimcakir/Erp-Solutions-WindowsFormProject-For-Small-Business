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

namespace MarketOtomasyon.UI.Windows.ProductItem
{
    public partial class ProductEdit : DevExpress.XtraEditors.XtraForm
    {
        int ProductID = 0;
        public ProductEdit(int productID)
        {
            InitializeComponent();
            ProductID = productID;
        }
        IProductsService productsService = new ProductsService();
        ICategoriesService categoriesService = new CategoriesService();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            ProductsDto productDto = new ProductsDto();
            productDto.ProductName = txtProductName.Text;
            productDto.StockCount = int.Parse(txtProductStock.Text);
            productDto.InPrice = Convert.ToDecimal(txtProductInPrice.Text);
            productDto.SalesPrice = Convert.ToDecimal(txtProductSalesPrice.Text);
            productDto.CategoryId = Convert.ToInt32(cmbProductCategories.SelectedValue);
            try
            {
                if (ProductID > 0)
                {
                    productDto.ProductId = ProductID;
                    productsService.Update(productDto);
                }
                else
                {
                    productsService.Add(productDto);
                }

                MessageBox.Show("Kaydetme işlemi başarıyla tamamlandı...");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu! Hata detayı: \r\n" + ex.Message);
            }
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            if (ProductID > 0)
            {
                LoadProduct();
            }
        }

        private void LoadProduct()
        {
            List<CategoriesDto> categories = new List<CategoriesDto>();
            var category = categoriesService.GetAll().ToList();
            foreach (var item in category)
            {
                var sorgu = category.Select(p => new CategoriesDto { CategoryId = item.CategoryId, CategoryName = item.CategoryName }).FirstOrDefault();

                categories.Add(sorgu);
            }
            var productDto = productsService.GetById(ProductID);
            if (productDto != null)
            {

                cmbProductCategories.DataSource = categories;
                cmbProductCategories.DisplayMember = "CategoryName";
                cmbProductCategories.ValueMember = "CategoryId";
                cmbProductCategories.SelectedItem = productsService.GetAll().Where(p => p.ProductId == ProductID).Select(p => p.CategoryId).FirstOrDefault();
                txtProductName.Text = productDto.ProductName.ToString();
                txtProductStock.Text = productDto.StockCount.ToString();
                txtProductInPrice.Text = productDto.InPrice.ToString();
                txtProductSalesPrice.Text = productDto.SalesPrice.ToString();

            }
        }
    }
}