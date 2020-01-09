using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Generiska_klasser
{
    class Program
    {
        static void Main(string[] args)
        {
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

            ordbok["Micke"] = "Lärare";

            
            


        }
    }
}
