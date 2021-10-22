using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Dto.Dto
{
    public class CustomersDto
    {
        public int CustomerId { get; set; }
        public string NameSurname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public Nullable<decimal> WillGive { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
