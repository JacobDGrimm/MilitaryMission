using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Tank : Vehicle
    {
        Weapon Cannon = new Cannon();
        public override void Mount()
        {
            base.Mount();
        }
        public override void Shoot()
        {
            base.Shoot();
            Cannon.Fire();
        }
        public override void Load()
        {
            base.Load();
            Cannon.Load();
        }
    }
}
