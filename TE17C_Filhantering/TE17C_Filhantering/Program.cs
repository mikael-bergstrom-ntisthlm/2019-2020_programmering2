using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TE17C_Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("names.txt", "Albert");

            if (File.Exists("monsternames.txt"))
            {
                string[] monsterNames = File.ReadAllLines("monsternames.txt");

                Console.WriteLine(monsterNames[0].Split(';')[1]);
            }

            



            Console.ReadLine();

        }
    }
}
