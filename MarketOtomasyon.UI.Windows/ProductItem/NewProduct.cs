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

namespace MarketOtomasyon.UI.Windows.ProductItem
{
    public partial class NewProduct : DevExpress.XtraEditors.XtraForm
    {
        public NewProduct()
        {
            InitializeComponent();
        }
        IProductsService productService = new ProductsService();
        ICategoriesService categoriesService = new CategoriesService();

        private void NewProduct_Load(object sender, EventArgs e)
        {
            List<CategoriesDto> categories = new List<CategoriesDto>();
            var category = categoriesService.GetAll().ToList();
            foreach (var item in category)
            {
                var sorgu = category.Select(p => new CategoriesDto { CategoryId = item.CategoryId, CategoryName = item.CategoryName }).FirstOrDefault();

                categories.Add(sorgu);
            }
            cmbProductCategories.DataSource = categories;
            cmbProductCategories.DisplayMember = "CategoryName";
            cmbProductCategories.ValueMember = "CategoryId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProductsDto productsDto = new ProductsDto();
            productsDto.ProductName = txtProductName.Text;
            productsDto.CategoryId = Convert.ToInt32(cmbProductCategories.SelectedValue);
            productsDto.StockCount = Convert.ToInt32(txtProductStock.Text);
            productsDto.InPrice = Convert.ToDecimal(txtProductInPrice.Text);
            productsDto.SalesPrice = Convert.ToDecimal(txtProductSalesPrice.Text);
            productsDto.IsActive = true;
            productsDto.CreatedDate = DateTime.Now;
            productsDto.CreatedBy = Cache.EmployeeId;
            productsDto.Count = 1;
            try
            {
                productService.Add(productsDto);
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