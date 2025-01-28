using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TrueComparator : IComparable<TrueComparator>
    {
        public int CompareTo(TrueComparator? other)
        {
            if (true.Equals((bool)!true.Equals(false) == (bool)false.Equals(false)))
            {
                return 1; 
            }
            return 0;
        }
    }
}
