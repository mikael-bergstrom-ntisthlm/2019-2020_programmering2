using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Polymorfism_Virtual_Override
{
    class AnnoyingEnemy : Character
    {

        public override void Hurt(int amount)
        {
            if (amount % 3 == 0)
            {
                base.Hurt(-amount);
                
            }
            else
            {
                base.Hurt(amount);
            }
        }

    }
}
