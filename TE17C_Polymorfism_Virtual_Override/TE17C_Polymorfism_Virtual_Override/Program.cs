using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Polymorfism_Virtual_Override
{
    class Program: Character
    {
        static void Main(string[] args)
        {
            List<Character> allCharacters = new List<Character>();

            for (int i = 0; i < 100; i++)
            {
                allCharacters.Add(new AnnoyingEnemy());
            }

            for (int i = 0; i < 20; i++)
            {
                allCharacters.Add(new Character());
            }

            for (int i = 0; i < allCharacters.Count; i++)
            {
                allCharacters[i].Hurt(4);
            }


            Console.ReadLine();
        }
    }
}
