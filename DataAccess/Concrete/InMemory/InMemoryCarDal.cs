using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            { 
                new Car{Id=1,BrandId=1,ColorId=10,DailyPrice=146000,ModelYear="2014",Description="AUDI A3"},
                 new Car{Id=2,BrandId=2,ColorId=20,DailyPrice=920000,ModelYear="2015",Description="MUSTANG 2.3 FASTBACK"},
                  new Car{Id=3,BrandId=3,ColorId=30,DailyPrice=730000,ModelYear="2016",Description="AUDİ A6 2.0 TDİ QUATTRO"},
            };
        }



        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car Cartodelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(Cartodelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByCarId()
        {
            return _cars;
        }

        public List<Car> GetByCarId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId ).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;
            _cars.Remove(CarToUpdate);

        }
    }
}
