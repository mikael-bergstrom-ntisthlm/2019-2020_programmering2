using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17B_GeneriskaKlasser
{
    class Program
    {

        delegate void Thing(int h);

        static void Hey(int u)
        {
            Console.WriteLine("Hey!" + u);
        }

        static void Yay(int k)
        {
            Console.WriteLine("Yay!" + k*2);
        }

        static void Main(string[] args)
        {


            List<string> names = new List<string>();

            names.Add("Micke");

            Queue<string> alsoNames = new Queue<string>();

            alsoNames.Enqueue("Rudolf");
            alsoNames.Enqueue("Jean-Pierre");
            
            string checkNext = alsoNames.Peek();

            string nextCustomer = alsoNames.Dequeue();


            Stack<int> numbers = new Stack<int>();

            numbers.Push(3);
            numbers.Push(23);
            numbers.Push(888);

            int h = numbers.Pop();

            HashSet<string> namesAgain = new HashSet<string>();

            namesAgain.Add("Micke");
            namesAgain.Add("Micke");


            Dictionary<string, string> ordbok = new Dictionary<string, string>();

            ordbok["Micke"] = "Lärare";

            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            Dictionary<Enemy, string> enemyWarcries = new Dictionary<Enemy, string>();

            enemyWarcries[e1] = "Hejkon bejkon!";


            Dictionary<Enemy, Enemy> nemesises = new Dictionary<Enemy, Enemy>();

            nemesises[e1] = e2;



            Thing r = Yay;

            r(5);

            r = Hey;

            r(8);

            Dictionary<string, Thing> options = new Dictionary<string, Thing>();

            options["1"] = Hey;
            options["2"] = Yay;

            string o = Console.ReadLine();

            if (options.ContainsKey(o))
            {
                options[o](5);
            }


            Container<string> c = new Container<string>();

            c.contents = "Sopor";

            c.next = new Container<string>();
            c.next.next = new Container<string>();
            c.next.next.next = new Container<string>();
            c.next.next.next.next = c;

            Container<string> current = c;
            while (current.next != null)
            {
                Console.WriteLine(current.contents);
                current = current.next;
            }


            Container<int> c2 = new Container<int>();

            c2.contents = 4;


            Console.ReadLine();

        }
    }
}
