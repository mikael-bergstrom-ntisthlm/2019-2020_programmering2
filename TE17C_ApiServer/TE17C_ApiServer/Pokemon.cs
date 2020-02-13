using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TE17C_ApiServer
{
    public class Pokemon
    {

        public int Strength { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0)
                {
                    name = value.ToUpper();
                }
                
            }
        }

    }
}
