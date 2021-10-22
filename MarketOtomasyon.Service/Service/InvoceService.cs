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
    public interface IInvoceService
    {
        List<InvoceDto> GetAll();
        InvoceDto GetById(int id);
        void Add(InvoceDto dto);
        void Update(InvoceDto dto);

        void Delete(int id);


    }
    public class InvoceServive : IInvoceService
    {


        public List<InvoceDto> GetAll()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.InvoceRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Invoce, InvoceDto>).ToList();

            }

        }
        public InvoceDto GetById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.InvoceRepository.GetById(id);
                return MapperFactory.Map<Invoce, InvoceDto>(entity);
            };

        }

        public void Add(InvoceDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<InvoceDto, Invoce>(dto);

                uow.InvoceRepository.Add(entity);
                uow.SaveChanges();

            }

        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.InvoceRepository.GetById(id);

                uow.InvoceRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(InvoceDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {

                var entity = MapperFactory.Map<InvoceDto, Invoce>(dto);

                uow.InvoceRepository.Update(entity);
                uow.SaveChanges();

            }
        }

    }
}
