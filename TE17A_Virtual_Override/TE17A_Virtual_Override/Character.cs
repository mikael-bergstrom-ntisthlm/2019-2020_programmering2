using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Virtual_Override
{
    class Character
    {
        public int hp = 100;

        public void Attack(Character opponent)
        {
            opponent.Hurt(5);
        }

        public virtual void Hurt(int amount)
        {
            amount = Math.Max(0, amount);

            hp -= amount;
        }

    }
}
