using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Helicopter : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("The helo takes off into the sky a majestic bird of prey.");
        }

        public override void Mount()
        {
            base.Mount();
        }
    }
}
