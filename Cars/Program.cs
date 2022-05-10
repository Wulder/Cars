using System;

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shop shop = new Shop(); //создание магазина
            CarService service = new CarService(); //создание автосервиса для диагностики и ремонта

            Car car1 = shop.Buy(0);
            Driver driver = new Driver(car1);
            driver.PushGas();

            Car car2 = shop.Buy(3);
            driver.SeatOnCar(car2);
            driver.PushGas();

            car1.GetDamage(256);
            car2.GetDamage(89);

            service.Diagnostic(car1);
            service.Repair(car2);
            service.Diagnostic(car2);

            
            
           
        }
    }
}