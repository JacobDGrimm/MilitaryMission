using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class MachineGun : Weapon
    {
        int RateOfFire = 10;
        public override void Fire()
        {
            for (int i = 0; i < RateOfFire; i++)
            {
                base.Fire();
            }
           
        }
    }
}
