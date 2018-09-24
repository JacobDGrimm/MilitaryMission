using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Cannon : Explosive
    {
        public override void Fire()
        {
            base.Fire();
            Explode();
        }
        public override void Load()
        {
            Console.WriteLine("The heavy cannon shell is loaded into the breach");
            base.Load();
        }
       
    }
}
