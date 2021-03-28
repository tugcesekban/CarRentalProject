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

            // CarTest();

            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + "/" + car.BrandName + "/"+ car.ColorName);
            //}
            //GetById
            //foreach (var car in carManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(car.CarName);
            //}
            //GetAll
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Name: " + car.Description + " Daily Fee: " + car.DailyPrice + " Model Year: " + car.ModelYear);
            //}
            //Add
          //  carManager.Add(new Car { BrandId = 3, CarId = 3, CarName = "Mini cooper", ColorId = 3, DailyPrice = 400, Description = "Big Experience", ModelYear = 2017 });          
            //Add
            //carManager.Add(new Car
            //{
            //    BrandId = 1,
            //    CarId = 3,
            //    ColorId = 2,
            //    DailyPrice = 600,
            //    Description = "Automatic temperature control",
            //    ModelYear = 2019
            //});
        }
        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAllByUnitPrice(100, 500))
        //    {
        //        Console.WriteLine(car.BrandId);
        //    }
        //}
    }
}
