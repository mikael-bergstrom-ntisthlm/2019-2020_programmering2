using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Virtual_Override
{
    class Ogre : Character
    {

        public override void Hurt(int amount)
        {
            hp -= amount / 2;
        }

    }
}
