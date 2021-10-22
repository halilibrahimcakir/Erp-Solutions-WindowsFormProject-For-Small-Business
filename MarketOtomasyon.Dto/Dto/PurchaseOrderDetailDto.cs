using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Dto.Dto
{
    public class PurchaseOrderDetailDto
    {
        public int PurchaseOrderDetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int PurchaseOrderId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> QuantitySumPrice { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }
}
