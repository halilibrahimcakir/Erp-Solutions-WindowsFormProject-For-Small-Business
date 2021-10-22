using MarketOtomasyon.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Data.Repository
{
    public class PurchaseOrderRepository : RepositoryBase<PurchaseOrder>, IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public PurchaseOrderRepository()
        {

        }
    }

    interface IPurchaseOrderRepository
    {

    }
}
