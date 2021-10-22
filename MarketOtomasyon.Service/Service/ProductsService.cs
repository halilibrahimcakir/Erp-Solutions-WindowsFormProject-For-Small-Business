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
    public interface IProductsService
    {
        List<ProductsDto> GetAll();
        ProductsDto GetById(int id);
        void Add(ProductsDto dto);
        void Update(ProductsDto dto);

        void Delete(int id);
    }
    public class ProductsService : IProductsService
    {


        public List<ProductsDto> GetAll()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.ProductsRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Products, ProductsDto>).ToList();

            }

        }
        public ProductsDto GetById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductsRepository.GetById(id);
                return MapperFactory.Map<Products, ProductsDto>(entity);

            }

        }

        public void Add(ProductsDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<ProductsDto, Products>(dto);

                uow.ProductsRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.ProductsRepository.GetById(id);

                uow.ProductsRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(ProductsDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<ProductsDto, Products>(dto);

                uow.ProductsRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }
}
