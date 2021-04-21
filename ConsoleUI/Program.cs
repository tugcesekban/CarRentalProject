using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // BrandTest();
            // ColorTest();
            //  CarTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { Id = 3, CarId = 1, CustomerId = 2, RentDate = Convert.ToDateTime("03.03.2021"), ReturnDate = Convert.ToDateTime("07.03.2021") });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //  carManager.Add(new Car { BrandId = 3, CarId = 3, CarName = "Mini cooper", ColorId = 3, DailyPrice = 400, Description = "Big Experience", ModelYear = 2017 });  

            // carManager.Delete(new Car { CarId=3});

            //  carManager.Update(new Car { BrandId = 3, CarId = 3, CarName = "Mini cooper", ColorId = 4, DailyPrice = 500, Description = "Big Experience", ModelYear = 2018 }); 

            //foreach (var car in carManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(car.CarName);
            //}

            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine(car.CarName);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Name: " + car.Description + " Daily Fee: " + car.DailyPrice + " Model Year: " + car.ModelYear);
            //}
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Delete(new Color { ColorId = 5 });

            // colorManager.Update(new Color { ColorId = 3, ColorName = "Green" });

            //colorManager.Add(new Color { ColorId = 5, ColorName= "Pink" });

            //foreach (var color in colorManager.GetColorByColorId(2))
            //{
            //    Console.WriteLine("Name: " + color.ColorName + " Brand Id: " + color.ColorId);
            //}

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine("Name: " + color.ColorName + " Color Id: " + color.ColorId);

            //}
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Delete(new Brand { BrandId = 5 });
            // brandManager.Update(new Brand { BrandId=4, BrandName= "Audi" });

            //brandManager.Add(new Brand { BrandId = 5, BrandName= "Jeep" });

            //foreach (var brand in brandManager.GetBrandByBrandId(1))
            //{
            //    Console.WriteLine("Name: " + brand.BrandName + " Brand Id: " + brand.BrandId);
            //}

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine("Name: " + brand.BrandName + " Brand Id: " + brand.BrandId);
            //}
        }
       
    }
}
