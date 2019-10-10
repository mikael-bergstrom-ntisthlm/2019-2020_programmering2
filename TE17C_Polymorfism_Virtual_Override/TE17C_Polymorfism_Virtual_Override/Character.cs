using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Polymorfism_Virtual_Override
{
    class Character
    {
        public class Test : Character
        {

        }


        protected int hp = 100;

        private string hej;
        public virtual void Hurt(int amount)
        {
            hp -= amount;

            if (hp < 0)
            {
                hp = 0;
            }

        }

    }
}
