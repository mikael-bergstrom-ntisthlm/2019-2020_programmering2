using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_Inkapsling_properties
{
    class Hero
    {
        int xp = 0;

        public int Xp
        {
            set
            {
                xp = value;
            }
            get
            {
                return xp;
            }
        }

        public int Level
        {
            get
            {
                return 1 + xp / 100;
            }
        }

        public void SetXp(int amount)
        {
            xp = amount;
        }

        public int GetXp()
        {
            return xp;
        }

        public int GetLevel()
        {
            return 1 + xp / 100;
        }


    }
}
