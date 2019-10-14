using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero h1 = new Hero();

            Console.WriteLine(h1.name);

            Enemy e1 = new Enemy();


            Character c = new Hero();
            Character c2 = new Enemy();

            
            List<Character> alla = new List<Character>();

            alla.Add(h1);
            alla.Add(e1);


            Console.ReadLine();
        }
    }
}
