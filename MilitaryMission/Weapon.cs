using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Weapon
    {
        public virtual void Fire()
        {
            Console.WriteLine("Bang!");
        }
        public virtual void Load()
        {
            Console.WriteLine("You are now loaded and ready to fire.");
        }
    }
}
