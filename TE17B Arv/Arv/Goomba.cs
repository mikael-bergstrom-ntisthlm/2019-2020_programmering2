using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Goomba : Enemy
    {

        public Goomba()
        {
            name = "Goomba";
            hp = 30;
        }

        public void DoSomeShit()
        {
            hp = maxHp;
        }

    }
}
