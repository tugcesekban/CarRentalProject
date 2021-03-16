using Business.Concreate;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Name: " + car.Description + " Daily Fee: " + car.DailyPrice + " Model Year: " + car.ModelYear);
            }
        }
    }
}
