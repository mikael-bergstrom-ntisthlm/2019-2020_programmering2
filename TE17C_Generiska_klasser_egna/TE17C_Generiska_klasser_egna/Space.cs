using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17C_Generiska_klasser_egna
{
    class Space<T>
    {
        public T content;

        public Space<T> up;
        public Space<T> down;
        public Space<T> left;
        public Space<T> right;

    }
}
