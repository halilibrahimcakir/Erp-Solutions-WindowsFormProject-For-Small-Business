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
    public interface ICategoriesService
    {
        List<CategoriesDto> GetAll();
        CategoriesDto GetById(int id);
        void Add(CategoriesDto dto);
        void Update(CategoriesDto dto);
        void Delete(int id);


    }
    public class CategoriesService : ICategoriesService
    {


        public List<CategoriesDto> GetAll()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.CategoriesRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Categories, CategoriesDto>).ToList();
            }
        }



        public CategoriesDto GetById(int id)
        {
            CategoriesDto result = new CategoriesDto();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CategoriesRepository.GetById(id);

                return MapperFactory.Map<Categories, CategoriesDto>(entity);
            }
        }

        public void Add(CategoriesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<CategoriesDto, Categories>(dto);

                uow.CategoriesRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(CategoriesDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<CategoriesDto, Categories>(dto);

                uow.CategoriesRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.CategoriesRepository.GetById(id);

                uow.CategoriesRepository.Delete(entity);
                uow.SaveChanges();
            }
        }


    }
}
