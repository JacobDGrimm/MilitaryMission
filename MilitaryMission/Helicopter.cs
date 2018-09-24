using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Helicopter : Vehicle
    {
        Weapon Hellfire = new Missle();
        public void Fly()
        {
            Console.WriteLine("The helo takes off into the sky a majestic bird of prey.");
        }

        public override void Shoot()
        {
            Hellfire.Fire();
            base.Shoot();
        }

        public override void Mount()
        {
            base.Mount();
            Console.WriteLine("The driver starts up all the doo dads and gizmos to take off");
        }
    }
}
