using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"IdNo:{item.Id}   model{item.Description}     marka No:{item.BrandId}");
            }

            carManager.Add(new Car { Id = 6, BrandId = 2, ColorId = 1, ModelYear = "1978", DailyPrice = 12.000m, Description = "Klasik" });

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"IdNo:{item.Id}   model{item.Description}     marka No:{item.BrandId}");
            }

            carManager.Delete(new Car { Id = 2 });

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"IdNo:{item.Id}   model{item.Description}     marka No:{item.BrandId}");
            }

            foreach (var item in carManager.GetByBrandId(2))
            {
                Console.WriteLine(item.Id);
            }

            foreach (var item in carManager.GetByColorId(1))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
