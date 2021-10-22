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
    public interface IEmployeeTypeService
    {
        List<EmployeeTypeDto> GetAll();
        EmployeeTypeDto GetById(int id);
        void Add(EmployeeTypeDto dto);
        void Update(EmployeeTypeDto dto);
        void Delete(int id);


    }
    public class EmployeeTypesService : IEmployeeTypeService
    {


        public List<EmployeeTypeDto> GetAll()
        {
            List<EmployeeTypeDto> result = new List<EmployeeTypeDto>();
            using (UnitOfWork uow = new UnitOfWork())
            {
                var list = uow.EmployeeTypeRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<EmployeeType, EmployeeTypeDto>).ToList();
            }
        }



        public EmployeeTypeDto GetById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeeTypeRepository.GetById(id);

                return MapperFactory.Map<EmployeeType, EmployeeTypeDto>(entity);
            }
        }

        public void Add(EmployeeTypeDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<EmployeeTypeDto, EmployeeType>(dto);

                uow.EmployeeTypeRepository.Add(entity);
                uow.SaveChanges();
            }
        }

        public void Update(EmployeeTypeDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<EmployeeTypeDto, EmployeeType>(dto);

                uow.EmployeeTypeRepository.Update(entity);
                uow.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeeTypeRepository.GetById(id);

                uow.EmployeeTypeRepository.Delete(entity);
                uow.SaveChanges();
            }
        }


    }
}
