using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Properties
{
    class Hero
    {
        private int xp = 0;

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string SurName { get; set; }

        public int Xp
        {
            get
            {
                return xp;
            }
            set
            {
                xp = value;
            }
        }

        public int Level
        {
            get
            {
                return 1 + xp / 10;
            }
            private set
            {

            }
        }


        public void AddXp(int amount)
        {
            xp += amount;
        }

        public int GetXp()
        {
            return xp;
        }

    }
}
