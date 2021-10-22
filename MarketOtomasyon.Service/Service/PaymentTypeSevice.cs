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
    public interface IPaymentTypeService
    {
        List<PaymentTypeDto> GetAll();
        PaymentTypeDto GetById(int id);
        void Add(PaymentTypeDto dto);
        void Update(PaymentTypeDto dto);

        void Delete(int id);


    }
    public class PaymentTypeService : IPaymentTypeService
    {


        public List<PaymentTypeDto> GetAll()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {

                var list = uow.PaymentTypeRepository.GetAll().ToList();
                return list.Select(MapperFactory.Map<PaymentType, PaymentTypeDto>).ToList();

            }

        }
        public PaymentTypeDto GetById(int id)
        {
            PaymentTypeDto result = new PaymentTypeDto();
            using (UnitOfWork uow = new UnitOfWork())
            {

                var entity = uow.PaymentTypeRepository.GetById(id);
                return MapperFactory.Map<PaymentType, PaymentTypeDto>(entity);

            }

        }

        public void Add(PaymentTypeDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PaymentTypeDto, PaymentType>(dto);

                uow.PaymentTypeRepository.Add(entity);
                uow.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = uow.PaymentTypeRepository.GetById(id);

                uow.PaymentTypeRepository.Delete(entity);
                uow.SaveChanges();
            }
        }



        public void Update(PaymentTypeDto dto)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entity = MapperFactory.Map<PaymentTypeDto, PaymentType>(dto);

                uow.PaymentTypeRepository.Update(entity);
                uow.SaveChanges();

            }
        }


    }
}
