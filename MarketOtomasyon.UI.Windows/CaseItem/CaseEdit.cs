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

namespace MarketOtomasyon.UI.Windows.CaseItem
{
    public partial class CaseEdit : DevExpress.XtraEditors.XtraForm
    {
        int OrderID = 0;
        int OrderDetailID = 0;
        decimal TotalPrice = 0;
        public CaseEdit(int orderID, decimal totalPrice)
        {
            InitializeComponent();
            OrderID = orderID;
            TotalPrice = totalPrice;
        }
        IPurchaseOrderService purchaseOrderService = new PurchaseOrderService();
        IPurchaseOrderDetailService purchaseOrderDetailService = new PurchaseOrderDetailService();
        IProductsService productsService = new ProductsService();
        public static List<PurchaseOrderDetailDto> GivenProducts = new List<PurchaseOrderDetailDto>();
        private void CaseEdit_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            lblOrderID.Text = OrderID.ToString();
            lblOrderTotalPrice.Text = TotalPrice.ToString() + "TL";
            LoadOrderDetail();

        }
        private void LoadOrderDetail()
        {
            var sorgu = (from pod in purchaseOrderDetailService.GetAll()
                         select new PurchaseOrderDetailDto
                         {
                             PurchaseOrderDetailId = pod.PurchaseOrderDetailId,
                             PurchaseOrderId = pod.PurchaseOrderId,
                             ProductId = pod.ProductId,
                             ProductName = pod.ProductName,
                             Quantity = pod.Quantity,
                             QuantitySumPrice = pod.QuantitySumPrice
                         }).Where(p => p.PurchaseOrderId == OrderID).ToList();
            var bindingList = new BindingList<PurchaseOrderDetailDto>(sorgu);
            dataGridView1.DataSource = bindingList;
        }
        private void bntDropPiece_Click(object sender, EventArgs e)
        {
            PurchaseOrderDetailDto purchaseOrderDetailDto = new PurchaseOrderDetailDto();
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int PurchaseOrderDetailId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PurchaseOrderDetailId"].Value);
                int ProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProductId"].Value);
                int Quantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantity"].Value);
                int QuantitySumPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["QuantitySumPrice"].Value);
                dataGridView1.SelectedRows[0].Cells["Quantity"].Value = Quantity - 1;
                int purchaseOrderID = PurchaseOrderDetailId;
                int productid = ProductId;
                int count = Quantity;
                int deletedrowSumprice = QuantitySumPrice;
                purchaseOrderDetailDto.ProductId = productid;
                purchaseOrderDetailDto.Quantity = count;
                purchaseOrderDetailDto.PurchaseOrderDetailId = purchaseOrderID;
                if (GivenProducts.Where(p => p.ProductId == productid).Count() > 0)
                {
                    var qq = purchaseOrderDetailService.GetById(PurchaseOrderDetailId);
                    qq.Quantity = count;
                    purchaseOrderDetailService.Update(qq);
                }
                else
                {
                    GivenProducts.Add(purchaseOrderDetailDto);
                }
            }
            else
            {
                MessageBox.Show("İlk önce bir ürün seçmelisiniz...");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PurchaseOrderDetailDto purchaseOrderDetailDto = new PurchaseOrderDetailDto();
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int PurchaseOrderDetailId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PurchaseOrderDetailId"].Value);
                int ProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProductId"].Value);
                int Quantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantity"].Value);
                int QuantitySumPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["QuantitySumPrice"].Value);
                int purchaseOrderID = PurchaseOrderDetailId;
                int productid = ProductId;
                int count = Quantity;
                int deletedrowSumprice = QuantitySumPrice;
                purchaseOrderDetailDto.ProductId = productid;
                purchaseOrderDetailDto.Quantity = count;
                purchaseOrderDetailDto.PurchaseOrderDetailId = purchaseOrderID;
                if (GivenProducts.Where(p => p.ProductId == productid).Count() > 0)
                {
                    var qq = purchaseOrderDetailService.GetById(PurchaseOrderDetailId);
                    qq.Quantity += count;
                    purchaseOrderDetailService.Update(qq);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                else
                {
                    GivenProducts.Add(purchaseOrderDetailDto);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("İlk önce bir ürün seçmelisiniz...");
            }

        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(OrderID + "numaralı sipariş iade edilicektir ! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Cache.Operation = true;
                dataGridView1.DataSource = null;
                GivenInvoker();
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GivenInvoker();
            Close();
        }

        private void GivenInvoker()
        {

            var islem = purchaseOrderService.GetById(OrderID);
            islem.UpdatedBy = Cache.EmployeeId;
            islem.UpdatedDate = DateTime.Now;
            ProductsDto productsDto = new ProductsDto();
            PurchaseOrderDetailDto purchaseOrderDetailDto = new PurchaseOrderDetailDto();

            var sorgu = purchaseOrderDetailService.GetAll().Where(p => p.PurchaseOrderId == OrderID).ToList();

            if (Cache.Operation == true)
            {
                foreach (var item in GivenProducts)
                {
                    var productAbout = productsService.GetById(GivenProducts.Select(p => item.ProductId).FirstOrDefault());
                    productAbout.StockCount += GivenProducts.Select(p => item.Quantity).FirstOrDefault();
                    islem.TotalPrice -= productAbout.SalesPrice;
                    purchaseOrderService.Update(islem);
                    var deleteProduct = sorgu.Where(p => p.ProductId == item.ProductId).Select(p => item.PurchaseOrderDetailId).FirstOrDefault();
                    purchaseOrderDetailService.Delete(deleteProduct);
                    
                }

                purchaseOrderDetailService.Delete(sorgu.Select(p=>p.PurchaseOrderDetailId).FirstOrDefault());
                purchaseOrderService.Delete(OrderID);
            }
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                islem.PurchaseOrderStatusId = 2;
                purchaseOrderService.Update(islem);
                foreach (var item in sorgu)
                {
                    productsDto.ProductId = sorgu.Select(p => item.ProductId).FirstOrDefault();
                    productsDto.Count = sorgu.Select(p => Convert.ToInt32(item.Quantity)).FirstOrDefault();
                    purchaseOrderDetailService.Delete(sorgu.Select(p => item.PurchaseOrderDetailId).FirstOrDefault());
                    var stockabout = productsService.GetById(productsDto.ProductId);
                    stockabout.StockCount += productsDto.Count;
                    productsService.Update(stockabout);
                }
            }
            else
            {
                foreach (var item in GivenProducts)
                {
                    var productAbout = productsService.GetById(GivenProducts.Select(p => item.ProductId).FirstOrDefault());
                    productAbout.StockCount += GivenProducts.Select(p => item.Quantity).FirstOrDefault();
                    islem.TotalPrice -= productAbout.SalesPrice;
                    purchaseOrderService.Update(islem);
                    var deleteProduct = sorgu.Where(p => p.ProductId == item.ProductId).Select(p => item.PurchaseOrderDetailId).FirstOrDefault();
                    purchaseOrderDetailService.Delete(deleteProduct);
                }
            }
        }
    }
}