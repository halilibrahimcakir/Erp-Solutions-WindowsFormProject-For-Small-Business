using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Dto.Dto
{
    public class InvoceDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PurchaseOrderId { get; set; }
        public Nullable<bool> IsPayed { get; set; }

    }
}
