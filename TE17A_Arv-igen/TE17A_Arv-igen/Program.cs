using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Arv_igen
{
    class Program
    {
        static void Main(string[] args)
        {
            Spaceship SPACESHIP = new Spaceship();
            Freighter nostromo = new Freighter();

            Spaceship ship = new Freighter();

            SPACESHIP.Attack();

            nostromo.Attack();

            ship.Attack();

            List<Spaceship> spaceships = new List<Spaceship>();

            spaceships.Add(SPACESHIP);
            spaceships.Add(nostromo);
            spaceships.Add(ship);


            for (int i = 0; i < spaceships.Count; i++)
            {
                if (spaceships[i] != nostromo)
                {
                    spaceships[i].Attack(nostromo);
                }

                
            }


            Console.ReadLine();

        }
    }
}
