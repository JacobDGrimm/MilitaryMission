﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Missle : Weapon
    {
        public override void Fire()
        {
            base.Fire();
            Explode();
        }
        public void Explode()
        {

        }
    }
}
