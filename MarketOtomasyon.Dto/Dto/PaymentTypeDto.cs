using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Dto.Dto
{
    public class PaymentTypeDto
    {
        public int PaymentTypeId { get; set; }
        public string Name { get; set; }
        public string IsActive { get; set; }
    }
}
