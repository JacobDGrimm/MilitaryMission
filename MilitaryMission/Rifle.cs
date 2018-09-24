using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Rifle: Weapon
    {
        public override void Load()
        {
            Console.WriteLine("A mag is slapped in the magazine port");
            base.Load();
        }

    }
}
