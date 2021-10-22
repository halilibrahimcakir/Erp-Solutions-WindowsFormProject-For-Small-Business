using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOtomasyon.Data.Context;

namespace MarketOtomasyon.Data.Repository
{
    public class UnitOfWork : IDisposable
    {

        #region Variable
        private readonly MarketBarkodDBEntities _contex;

        private CategoriesRepository _categoriesRepository = null;
        private CustomersRepository _customersRepository = null;
        private EmployeeRepository _employeeRepository = null;
        private ProductsRepository _productsRepository = null;
        private PurchaseOrderRepository _purchaseOrderRepository = null;
        private CustomerSummaryRepository _customerSummaryRepository = null;
        private InvoceRepository _invoceRepository = null;
        private SuppliersRepository _suppliesRepository = null;
        private PaymentTypeRepository _paymentTypeRepository = null;
        private EmployeeTypeRepository _employeeTypeRepository = null;
        private PurchaseOrderDetailRepository _purchaseOrderDetailRepository = null;
        private PurchaseOrderStatusRepository _purchaseOrderStatusRepository = null;
        #endregion


        #region Ctor
        public UnitOfWork()
        {
            _contex = new MarketBarkodDBEntities();
        }

        #endregion

        #region Repository

        public PurchaseOrderStatusRepository PurchaseOrderStatusRepository
        {
            get
            {
                if (_purchaseOrderStatusRepository == null)
                {
                    _purchaseOrderStatusRepository = new PurchaseOrderStatusRepository(_contex);
                };
                return _purchaseOrderStatusRepository;
            }

        }

        public PurchaseOrderDetailRepository PurchaseOrderDetailRepository
        {
            get
            {
                if (_purchaseOrderDetailRepository == null)
                {
                    _purchaseOrderDetailRepository = new PurchaseOrderDetailRepository(_contex);
                };
                return _purchaseOrderDetailRepository;
            }

        }

        public PaymentTypeRepository PaymentTypeRepository
        {
            get
            {
                if (_paymentTypeRepository == null)
                {
                    _paymentTypeRepository = new PaymentTypeRepository(_contex);
                };
                return _paymentTypeRepository;
            }

        }
        public EmployeeTypeRepository EmployeeTypeRepository
        {
            get
            {
                if (_employeeTypeRepository == null)
                {
                    _employeeTypeRepository = new EmployeeTypeRepository(_contex);
                };
                return _employeeTypeRepository;
            }
        }

        public SuppliersRepository SuppliesRepository
        {
            get
            {
                if (_suppliesRepository == null)
                {
                    _suppliesRepository = new SuppliersRepository(_contex);
                };
                return _suppliesRepository;
            }
        }

        public InvoceRepository InvoceRepository
        {
            get
            {
                if (_invoceRepository == null)
                {
                    _invoceRepository = new InvoceRepository(_contex);
                };
                return _invoceRepository;
            }
        }

        public CustomerSummaryRepository CustomerSummaryRepository
        {
            get
            {
                if (_customerSummaryRepository == null)
                {
                    _customerSummaryRepository = new CustomerSummaryRepository(_contex);
                };
                return _customerSummaryRepository;
            }
        }

        public CategoriesRepository CategoriesRepository
        {
            get
            {
                if (_categoriesRepository == null)
                {
                    _categoriesRepository = new CategoriesRepository(_contex);
                }
                return _categoriesRepository;
            }
        }
        public CustomersRepository CustomersRepository
        {
            get
            {
                if (_customersRepository == null)
                {
                    _customersRepository = new CustomersRepository(_contex);
                }
                return _customersRepository;
            }
        }
        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_contex);
                }
                return _employeeRepository;
            }
        }

        public ProductsRepository ProductsRepository
        {
            get
            {
                if (_productsRepository == null)
                {
                    _productsRepository = new ProductsRepository(_contex);
                }
                return _productsRepository;
            }
        }

        public PurchaseOrderRepository PurchaseOrderRepository
        {
            get
            {
                if (_purchaseOrderRepository == null)
                {
                    _purchaseOrderRepository = new PurchaseOrderRepository(_contex);
                }
                return _purchaseOrderRepository;
            }
        }

        #endregion

        #region Transactions
        public void BeginTransaction()
        {
            _contex.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _contex.Database.CurrentTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            _contex.Database.CurrentTransaction.Rollback();
        }

        public int SaveChanges()
        {
            try
            {
                return _contex.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Disposable
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}
