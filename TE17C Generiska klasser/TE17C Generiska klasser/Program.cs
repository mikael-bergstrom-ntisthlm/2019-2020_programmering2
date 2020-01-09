using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Generiska_klasser
{
    class Program
    {

        delegate void DoThing();

        static void Hey()
        {
            Console.WriteLine("Hey");
        }

        static void Yay()
        {
            Console.WriteLine("Yay");
        }


        static void Main(string[] args)
        {

            List<string> names = new List<string>();

            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(8);
            numbers.Enqueue(88);
            numbers.Enqueue(888);
            numbers.Enqueue(8888);

            Stack<int> alsoNumbers = new Stack<int>();

            alsoNumbers.Push(6);

            int u = alsoNumbers.Pop();

            int y = numbers.Dequeue();

            Console.WriteLine(y);


            Dictionary<string, string> ordbok = new Dictionary<string, string>();

            ordbok["Micke"] = "Lärare";
            ordbok["NTI-elev"] = "Nörd";
            ordbok["PC"] = "Master race";
            ordbok["All your base"] = "Belong to us";

            //string g = ordbok.Keys.ToArray<string>()[0];

            foreach(string key in ordbok.Keys)
            {
                Console.WriteLine(key);
            }


            //Console.WriteLine(g);

            VanligGrej g1 = new VanligGrej();
            VanligGrej g2 = new VanligGrej();

            Dictionary<VanligGrej, string> grejer = new Dictionary<VanligGrej, string>();

            grejer[g1] = "hej";

            Dictionary<VanligGrej, VanligGrej> hatobjekt = new Dictionary<VanligGrej, VanligGrej>();


            hatobjekt[g1] = g2;



            Dictionary<string, DoThing> actions = new Dictionary<string, DoThing>();

            actions["1"] = Hey;
            actions["2"] = Yay;

            actions["1"]();


            Console.ReadLine();
        }
    }
}
