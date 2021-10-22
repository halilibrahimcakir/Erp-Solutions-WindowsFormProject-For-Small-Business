using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Dto.Dto
{
    public class PurchaseOrderDto
    {
        public int PurchaseOrderId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public Nullable<bool> IsApporeved { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> PurchaseOrderStatusId { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    }
}
