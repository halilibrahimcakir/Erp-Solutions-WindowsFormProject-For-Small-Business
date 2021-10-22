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
    public interface IPurchaseOrderStatusService
    {
        List<PurchaseOrderStatusDto> GetAll();
        PurchaseOrderStatusDto GetById(int id);
        void Add(PurchaseOrderStatusDto dto);
        void Update(PurchaseOrderStatusDto dto);

        void Delete(int id);


    }
    public class PurchaseOrderStatusService : IPurchaseOrderStatusService
    {


        public List<PurchaseOrderStatusDto> GetAll()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.PurchaseOrderStatusRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<PurchaseOrderStatus, PurchaseOrderStatusDto>).ToList();
            }
        }



        public PurchaseOrderStatusDto GetById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderStatusRepository.GetById(id);

                return MapperFactory.Map<PurchaseOrderStatus, PurchaseOrderStatusDto>(entity);
            }
        }

        public void Add(PurchaseOrderStatusDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PurchaseOrderStatusDto, PurchaseOrderStatus>(dto);

                uow.PurchaseOrderStatusRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(PurchaseOrderStatusDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PurchaseOrderStatusDto, PurchaseOrderStatus>(dto);

                uow.PurchaseOrderStatusRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PurchaseOrderDetailRepository.GetById(id);

                uow.PurchaseOrderDetailRepository.Delete(entity);
                uow.SaveChanges();
            }
        }


    }
}
