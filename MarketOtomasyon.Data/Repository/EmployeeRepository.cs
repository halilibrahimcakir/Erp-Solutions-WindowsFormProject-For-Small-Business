using MarketOtomasyon.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketOtomasyon.Data.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public EmployeeRepository()
        {

        }
    }

    interface IEmployeeRepository
    {

    }
}
