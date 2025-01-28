using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CS_Advanced.Sorted_Dictionary
{
    internal class StringSortedDec : IComparer<string>
    {
        
          
        public int Compare(string? x, string? y)
        {
            if (x == null && y == null)
                return 0;

            if (x == null || y == null)
                return 1;
            return y.CompareTo(x) ;
        }
    }
}
