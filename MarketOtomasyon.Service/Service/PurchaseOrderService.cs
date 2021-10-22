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
    public interface IPurchaseOrderService
    {

        List<PurchaseOrderDto> GetAll();
        PurchaseOrderDto GetById(int id);
        void Add(PurchaseOrderDto dto);
        void Update(PurchaseOrderDto dto);

        void Delete(int id);

    }
    public class PurchaseOrderService : IPurchaseOrderService
    {
        public List<PurchaseOrderDto> GetAll()
        {
            List<PurchaseOrderDto> result = new List<PurchaseOrderDto>();


            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.PurchaseOrderRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<PurchaseOrder, PurchaseOrderDto>).ToList();

            }

        }
        public PurchaseOrderDto GetById(int id)
        {
            PurchaseOrderDto result = new PurchaseOrderDto();

            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderRepository.GetById(id);

                return MapperFactory.Map<PurchaseOrder, PurchaseOrderDto>(entity);

            }

        }

        public void Add(PurchaseOrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PurchaseOrderDto, PurchaseOrder>(dto);

                uow.PurchaseOrderRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderRepository.GetById(id);

                uow.PurchaseOrderRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(PurchaseOrderDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PurchaseOrderDto, PurchaseOrder>(dto);

                uow.PurchaseOrderRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }
}
