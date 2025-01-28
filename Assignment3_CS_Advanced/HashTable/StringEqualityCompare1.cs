using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CS_Advanced.HashTable
{
    internal class StringEqualityCompare1 : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {
            String? str1 = x as String;
            String? str2 = y as String;
          

            if (str1 == null && str2 == null)
                return true;

            if (str1 == null || str2 == null)
                return false;

            return str1.ToLower().Equals(str2.ToLower() );
        }

        public int GetHashCode(object obj)
        {
            String str = obj as String;

            return str?.ToLower().GetHashCode()?? 0;
        }
    }
}
