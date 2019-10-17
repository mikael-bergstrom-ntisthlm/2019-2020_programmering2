using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Virtual_Override
{
    class CursedWeapon: Weapon
    {

        public override int Attack()
        {
            return minDmg;
        }

    }
}
