using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_ReferenceValueTypes
{
    class Enemy
    {
        public string name;
        public Sword weapon = new Sword();

        public Enemy nemesis;
    }
}
