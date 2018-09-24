using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Enlisted : Personell
    {
        public override void Salute()
        {
            Console.WriteLine("The soldier snaps to obey");
            base.Salute();
        }
    }
}
