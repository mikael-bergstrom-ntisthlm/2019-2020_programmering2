using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Inkapsling
{
    class Hero
    {
        int xp = 0;

        //int level = 0;
        string name;
        public virtual string Name
        {
            get {
                return name;
            }
            protected set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
            }
        }

        public int Level
        {
            get
            {
                Random generator = new Random();
                return generator.Next(200);
            }
            private set
            {

            }
        }

        public int Xp
        {
            get
            {
                return xp;
            }

            set
            {
                xp = Math.Max(xp, value);

            }
        }



        public void AddXp(int amount)
        {
            amount = Math.Max(amount, 0);

            xp += amount;

            //level = 1 + xp / 10;
        }

        public int GetLevel()
        {
            return 1 + xp / 100;

            //return 1;
        }



    }
}
