using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Officer : Personell
    {
        public override void Salute()
        {
            base.Salute();
        }
        public void Command()
        {
            Console.WriteLine("Get to work men!");
        }
    }
}
