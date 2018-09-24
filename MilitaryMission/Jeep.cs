using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Jeep : Vehicle
    {
        Weapon M2 = new MachineGun();
        public void Drive()
        {

        }
        public override void Mount()
        {
            base.Mount();
            
        }
        public override void Load()
        {
            base.Load();
            M2.Load();
        }
        public override void Shoot()
        {
            base.Shoot();
            M2.Fire();
        }

    }
}
