using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Dto.Dto
{
    public class ProductsDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> StockCount { get; set; }
        public Nullable<bool> Discount { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> InPrice { get; set; }
        public Nullable<decimal> SalesPrice { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        //For View
        public string CategoryName { get; set; }

        public int Count { get; set; }
    }
}
