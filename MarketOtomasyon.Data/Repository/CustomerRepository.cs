using MarketOtomasyon.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Data.Repository
{
    public class CustomersRepository : RepositoryBase<Customers>, ICustomersRepository
    {
        public CustomersRepository(MarketBarkodDBEntities context) : base(context)
        {

        }

        public CustomersRepository()
        {

        }


    }

    interface ICustomersRepository
    {

    }
}
