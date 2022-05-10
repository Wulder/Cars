using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    abstract class SimpleCar : Car //абстрактный класс описывающий обычную машину (в понимании 4 колеса, обычный кузов, обычный двигатель), не монстертрэк, не машину из мэдмакса или машину с 3 колесами
    {
        public override void Gas()
        {
            Console.WriteLine("спокойно едем по дороге");
        }

        public override void GetDamage(float count)
        {
            base.GetDamage(count);
              Console.WriteLine("Выпустить подушки безопасности");
            
        }
    }

    
}
