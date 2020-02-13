using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Generiska_klasser
{
    class Program
    {
        delegate void AThing(int n);

        static void MakeStuff(int u)
        {

        }

        static void DoThings()
        {

        }


        static void Main(string[] args)
        {

            AThing thing = MakeStuff;

            Dictionary<string, Action> actions = new Dictionary<string, Action>();

            actions.Add("1", DoThings);



            actions["1"]();



            thing(7);

            List<string> names = new List<string>();


            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(8);
            numbers.Enqueue(88);
            numbers.Enqueue(888);
            numbers.Enqueue(8888);
            numbers.Enqueue(88888);

            int h = numbers.Dequeue();


            Stack<int> alsoNumbers = new Stack<int>();

            alsoNumbers.Push(9);

            int u = alsoNumbers.Pop();

            Thing<int> y = new Thing<int>();

            Dictionary<string, string> ordbok = new Dictionary<string, string>();

            //names[3] = 

            ordbok["Micke"] = "Lärare";

            //Dictionary<Dictionary<int, int>, Dictionary<string, string>> hej;

            //HashSet
            //Delegates


            Container<float> c1 = new Container<float>();

            c1.next = new Container<float>();
            c1.next.next = new Container<float>();

            c1.next.next.next = c1;

            Container<float> current = c1;

            while (current.next != null)
            {
                Console.WriteLine(current.contents);
                current = current.next;
            }


        }
    }
}
