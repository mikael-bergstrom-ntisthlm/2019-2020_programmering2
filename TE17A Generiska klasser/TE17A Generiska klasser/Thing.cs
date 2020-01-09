using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Generiska_klasser
{
    class Thing <T>
    {
        public T hello;

        private string name = "";

        public string GetName()
        {
            return name;
        }

    }
}
