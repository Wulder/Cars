using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class BigMonsterPickup : MonsterTrack
    {
        public override void Gas()
        {
            base.Gas();
            Console.WriteLine("пускаем огонь еще");
        }
    }
}
