using AutoMapper;
using MarketOtomasyon.Data.Context;
using MarketOtomasyon.Dto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketOtomasyon.Service.Mapper
{
    public static class MapperFactory
    {
        private static MapperConfiguration mapperConfiguration;
        private static bool _isInitialized;
        private static object lck = new object();

        public static K Map<T, K>(T input)
        {
            Init();

            IMapper mapper = mapperConfiguration.CreateMapper();

            return input != null ? mapper.Map<T, K>(input) : default(K);
        }

        private static void Init()
        {
            lock (lck)
            {
                if (_isInitialized) return;

                mapperConfiguration = new MapperConfiguration(p =>
                {
                    p.CreateMap<Employee, EmployeeDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<EmployeeType, EmployeeTypeDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Categories, CategoriesDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Products, ProductsDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Suppliers, SuppliersDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<PurchaseOrder, PurchaseOrderDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<PurchaseOrderDetail, PurchaseOrderDetailDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Invoce, InvoceDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<PaymentType, PaymentTypeDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<PurchaseOrderStatus, PurchaseOrderStatusDto>().MaxDepth(1).ReverseMap();
                    p.CreateMap<Customers, CustomersDto>().MaxDepth(1).ReverseMap();
                });
            }
            _isInitialized = true;
        }
    }
}