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
    public interface ISuppliesService
    {

        List<SuppliersDto> GetAll();
        SuppliersDto GetById(int id);
        void Add(SuppliersDto dto);
        void Update(SuppliersDto dto);

        void Delete(int id);


    }
    public class SuppliesService : ISuppliesService
    {


        public List<SuppliersDto> GetAll()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.SuppliesRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Suppliers, SuppliersDto>).ToList();
            }
        }



        public SuppliersDto GetById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.SuppliesRepository.GetById(id);

                return MapperFactory.Map<Suppliers, SuppliersDto>(entity);
            }
        }

        public void Add(SuppliersDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<SuppliersDto, Suppliers>(dto);

                uow.SuppliesRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(SuppliersDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<SuppliersDto, Suppliers>(dto);

                uow.SuppliesRepository.Update(entity);
                uow.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.SuppliesRepository.GetById(id);
                uow.SuppliesRepository.Delete(entity);
                uow.SaveChanges();
            }
        }
    }
}
