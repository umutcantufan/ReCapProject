using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //GetAllColors(colorManager);
            //GetAllCars(carManager);
            //GetAllBrands(brandManager);


            //carManager.Add(new Car { CarId = 5, BrandId = 5, Description = "X", ColorId = 1, DailyPrice = 0, ModelYear = 2008 }); //Araba eklenmicek istenilen şartlara uymuyor.



            //GetCarsByBrandId
            foreach (var car in carManager.GetCarsByBrandId(3)) //markaya göre getir
            {
                Console.WriteLine("{0} --- {1}", car.Description, car.BrandId);
            }


            //GetCarsByColorId
            foreach (var car in carManager.GetCarsByColorId(1)) //renge göre getir
            {
                Console.WriteLine("{0} --- {1}", car.Description, car.ColorId);
            }
        }




        //private static void GetAllBrands(BrandManager brandManager)
        //{
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.Name);
        //    }
        //}

        //private static void GetAllCars(CarManager carManager)
        //{
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}

        //private static void GetAllColors(ColorManager colorManager)
        //{
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.Name);
        //    }
        //}
    }

}