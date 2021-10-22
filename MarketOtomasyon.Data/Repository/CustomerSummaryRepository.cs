using MarketOtomasyon.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Data.Repository
{
    public class CustomerSummaryRepository : RepositoryBase<CustomerSummary>, ICustomerSummaryRepository
    {
        public CustomerSummaryRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public CustomerSummaryRepository()
        {

        }
    }

    interface ICustomerSummaryRepository
    {

    }
}
