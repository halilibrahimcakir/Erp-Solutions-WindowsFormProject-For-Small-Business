using MarketOtomasyon.Data.Context;
using MarketOtomasyon.Data.Repository;
using MarketOtomasyon.Dto.Dto;
using MarketOtomasyon.Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketOtomasyon.Service.Service
{
    public interface ICustomerService
    {
        List<CustomersDto> GetAll();
        CustomersDto GetById(int id);
        void Add(CustomersDto dto);
        void Update(CustomersDto dto);

        void Delete(int id);


    }
    public class CustomerService : ICustomerService
    {


        public List<CustomersDto> GetAll()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CustomersRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Customers, CustomersDto>).ToList();
            }
        }



        public CustomersDto GetById(int id)
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CustomersRepository.GetById(id);

                return MapperFactory.Map<Customers, CustomersDto>(entity);
            }
        }

        public void Add(CustomersDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<CustomersDto, Customers>(dto);

                uow.CustomersRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(CustomersDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<CustomersDto, Customers>(dto);

                uow.CustomersRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CustomersRepository.GetById(id);

                uow.CustomersRepository.Delete(entity);
                uow.SaveChanges();
            }
        }


    }
}
