using Business.Concrete;
using DataAccess.Concrete.InMemory;
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

                Console.WriteLine("CAR ID: "+ car.Id+ "  MODEL YEAR: "+car.ModelYear+"  CAR COLOR:  "+car.ColorId+"  CAR BRAND ID:  "+car.BrandId+"  CAR DAİLY PRİCE:  "+car.DailyPrice+"  CAR DESCRİPTİON:  "+car.Description);

            }
        }
    }
}
