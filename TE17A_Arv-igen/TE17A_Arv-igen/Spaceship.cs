using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Arv_igen
{
    class Spaceship
    {
        public int speed;

        public int hp = 100;

        public string name = "SPACESHIP!!!";

        public Spaceship()
        {
            speed = 10;
        }

        public virtual void Attack(Spaceship enemy)
        {
            Console.WriteLine("ATTACK!!!!");
            enemy.hp--;
        }

    }
}
