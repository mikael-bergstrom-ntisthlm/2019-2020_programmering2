using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE17A_Generiska_klasser
{
    class Container<T>
    {
        public T contents;

        public Container<T> next;

        public Container<T> up;
        public Container<T> down;
        public Container<T> left;
        public Container<T> right;

        public List<Container<T>> connections = new List<Container<T>>();



    }
}
