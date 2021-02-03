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
            _cars = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2010",DailyPrice=70.000m,Description="Amg" },
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear="2019",DailyPrice=100.000m,Description="Clk" },
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear="2012",DailyPrice=49.000m,Description="M3" },
                new Car{Id=4,BrandId=3,ColorId=3,ModelYear="2020",DailyPrice=110.000m,Description="A4" },
                new Car{Id=5,BrandId=3,ColorId=1,ModelYear="2008",DailyPrice=20.000m,Description="A3" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _cars.Where(p => p.ColorId == colorId).ToList();
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(p => p.Id == car.Id);
            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.ModelYear = car.ModelYear;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Id = car.Id;
        }
    }
}
