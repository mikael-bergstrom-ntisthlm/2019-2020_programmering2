using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TE17B_ApiServer
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Speed { get; set; } = 5;

        public int Strength { get; set; } = 10;

        /*private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }*/


        /*public string GetName()
        {
            return name;
        }

        public void SetName(string n)
        {
            if (n.Length > 0)
            {
                name = n.ToUpper();
            }
            
        }*/

    }
}
