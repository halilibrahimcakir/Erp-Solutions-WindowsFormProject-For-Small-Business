using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Dto.Dto
{
    public class CustomerSummaryDto
    {
        public int CustumerId { get; set; }
        public string NameSurname { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Phone { get; set; }
        public Nullable<decimal> WillGive { get; set; }
        public int CustomerSummaryId { get; set; }
    
    }
}
