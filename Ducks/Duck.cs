using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public Duck(int size, KindOfDuck kind)
        {
            Size = size;
            Kind = kind;
        }

        public int CompareTo(Duck other)
        {
            if (Size > other.Size)
                return 1;
            else if (Size < other.Size)
                return -1;
            else
                return 0;
        }
    }
}
