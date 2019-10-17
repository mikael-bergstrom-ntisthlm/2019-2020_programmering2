using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Virtual_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon w = new CursedWeapon();

            int monsterhp = 55;

            monsterhp -= w.Attack();

            Console.WriteLine(monsterhp);

            Character a = new Character();

            Character b = new Ogre();

            a.Attack(b);


            Console.ReadLine();
        }
    }
}
