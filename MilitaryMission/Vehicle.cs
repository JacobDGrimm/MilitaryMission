using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Vehicle
    {
        public virtual void Mount()
        {
            Console.WriteLine("The driver climbs aboard");
        }
        public virtual void Shoot()
        {
            Console.WriteLine("The gunner fires his weapon!");
        }
        public virtual void Load()
        {
            Console.WriteLine("The gunner gets his weapon ready.");
        }
    }
}
