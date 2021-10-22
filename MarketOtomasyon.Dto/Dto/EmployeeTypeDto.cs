using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Dto.Dto
{
    public class EmployeeTypeDto
    {
        public int EmployeeTypeId { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Description { get; set; }
    }
}
