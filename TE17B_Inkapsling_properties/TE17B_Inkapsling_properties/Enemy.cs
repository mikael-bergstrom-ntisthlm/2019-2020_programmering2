using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_Inkapsling_properties
{
    class Enemy
    {
        private int hp;

        public string Name {get; private set; }



        public int Hp
        {
            get
            {
                Console.WriteLine("YAY!");
                Random gen = new Random();
                return gen.Next(75, 200);
            }
            set
            {
                if (value >= 0)
                {
                    hp = value;
                }
                
            }
        }



        public void SetHp(int value)
        {
            if (value >= 0)
            {
                hp = value;
            }
        }

        public int GetHp()
        {
            Random gen = new Random();
            return gen.Next(75, 200);
        }

        public Enemy ()
        {
            Name = "Goomba";
        }

    }
}
