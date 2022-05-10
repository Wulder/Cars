using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class CarService
    {
        public void Diagnostic(Car c) //диагностируем машину
        {
            if (c.Strength < c.maxStrength)
                Console.WriteLine("Есть неполадки с автомобилем!");
            else
                Console.WriteLine("Машина в порядке!");
        }

        public void Repair(Car c) //ремонтируем машину
        {
            Console.WriteLine("Машина отремонтирована!");
            c.AddStrength(c.maxStrength - c.Strength);
        }
    }
}
