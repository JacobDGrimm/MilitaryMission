﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Missle : Explosive
    {
        public override void Fire()
        {
            base.Fire();
            Explode();
        }
        public override void Load()
        {
            Console.WriteLine("The missle sits in its rack ready to fire");
            base.Load();
        }
    }
}
