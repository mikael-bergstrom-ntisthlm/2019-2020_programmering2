using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te17a_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintArray(new string[] { "grej", "nej", "ej" });



            BlizzardLizardWizard eddie = new BlizzardLizardWizard();

            BlizzardLizardWizard freddie = new BlizzardLizardWizard();

            eddie.enemy = freddie;

            freddie.enemy = eddie;

            freddie.name = "Freddie";

            Console.WriteLine(eddie.enemy.enemy.enemy.enemy.enemy.name);



            

            //Console.WriteLine(eddie.name);
            //Console.WriteLine(freddie.name);


            Console.WriteLine(BlizzardLizardWizard.numberOf);

            Console.ReadLine();

        }

    }
}
