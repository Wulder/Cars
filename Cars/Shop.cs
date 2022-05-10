using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Shop 
    {
        List<Car> cars = new List<Car>();

        public Shop() 
        {
            cars.Add(new BMW());
            cars.Add(new MonsterTrack());
            cars.Add(new BMW());
            cars.Add(new MonsterTrack());
            cars.Add(new BMW());
            cars.Add(new MonsterTrack());
        }
        public Car Buy(int id) //покупаем машину указывая ее id в каталоге(просто берем элемент из листа по айди)
        {
            Console.WriteLine($"ПОздравляем с покупкой {cars[id]}!");
            return cars[id];
        }
    }
}
