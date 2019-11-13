using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Arv_igen
{
    class Freighter : Spaceship
    {


        public Freighter()
        {
            speed = 2;
            name = "Nostromo";
        }

        public override void Attack(Spaceship enemy)
        {
            Console.WriteLine("NO ATTACK!!!!!");
        }

    }
}
