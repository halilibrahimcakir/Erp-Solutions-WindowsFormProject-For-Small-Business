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
    public interface IEmployeeService
    {
        List<EmployeeDto> GetAll();
        EmployeeDto GetById(int id);
        void Add(EmployeeDto dto);
        void Update(EmployeeDto dto);
        void Delete(int id);


    }
    public class EmployeeService : IEmployeeService
    {


        public List<EmployeeDto> GetAll()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {

                var list = uow.EmployeeRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<Employee, EmployeeDto>).ToList();

            }

        }
        public EmployeeDto GetById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {

                var entity = uow.EmployeeRepository.GetById(id);
                return MapperFactory.Map<Employee, EmployeeDto>(entity);

            }

        }

        public void Add(EmployeeDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<EmployeeDto, Employee>(dto);

                uow.EmployeeRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.EmployeeRepository.GetById(id);

                uow.EmployeeRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(EmployeeDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<EmployeeDto, Employee>(dto);

                uow.EmployeeRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }
}
