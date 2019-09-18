using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te17a_Static
{
    class BlizzardLizardWizard
    {
        public BlizzardLizardWizard enemy; 

        public string name = "Eddie";

        public static int numberOf = 0;

        static Random generator = new Random();

        public BlizzardLizardWizard()
        {
            Console.WriteLine(generator.Next(55));
        }

    }
}
