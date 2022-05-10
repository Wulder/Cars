using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class MonsterTrack : Car //базовый класс для монстр треков, поведение которых достаточно сильно отличаются от обычных автомобилей
    {
        public override void Gas()
        {
            FireShow();
            Console.WriteLine("Рев двигателя, едем");
        }

        void FireShow()
        {
            Console.WriteLine("Пустить огонь с выхлопа");
        } //допустим что все монстр треки умеют пускать огонь с выхлопа и будем делать это по умолчанию для всех наследников

        public override void GetDamage(float count)
        {
            base.GetDamage(count);
            if (count >= 75)
            Console.WriteLine("Из машины пошел дым");
        }
    }
}
