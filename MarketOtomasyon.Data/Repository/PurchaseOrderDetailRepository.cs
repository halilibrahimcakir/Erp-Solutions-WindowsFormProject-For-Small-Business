using MarketOtomasyon.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyon.Data.Repository
{
    public class PurchaseOrderDetailRepository : RepositoryBase<PurchaseOrderDetail>, IPurchaseOrderDetailRepository
    {
        public PurchaseOrderDetailRepository(MarketBarkodDBEntities context) : base(context)
        {
        }


        public PurchaseOrderDetailRepository()
        {

        }
    }

    interface IPurchaseOrderDetailRepository
    {

    }
}
