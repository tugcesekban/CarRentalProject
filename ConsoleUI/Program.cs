using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Name: " + car.Description + " Daily Fee: " + car.DailyPrice + " Model Year: " + car.ModelYear);
            //}

            foreach (var car in carManager.GetAllByUnitPrice(100, 500))
            {
                Console.WriteLine(car.BrandId);
            }

            //carManager.Add(new Car
            //{
            //    BrandId = 1,
            //    CarId = 3,
            //    ColorId = 2,
            //    DailyPrice = 600,
            //    Description = "Automatic temperature control",
            //    ModelYear = 2019
            //});

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarId + car.BrandId +car.ColorId +car.DailyPrice+ car.Description);
            //}
        }
    }
}
