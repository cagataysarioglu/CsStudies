using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetByBrandId(7))
            {
                Console.WriteLine(car.DailyPrice);
            }

            foreach (var car in carManager.GetByColorId(3))
            {
                Console.WriteLine(car.ModelYear);
            }

            carManager.Add(new Car{BrandId = 2, ColorId = 1, DailyPrice = 290, ModelYear = 2019, Description = "Aile arabası."});
        }
    }
}
