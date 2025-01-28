using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_CS_Advanced.Genaruc_Collection_Dictionary
{
    internal class GenericStringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {

            if (x == null && y == null)
                return true;

            if (x == null || y == null)
                return false;

            return x.ToLower().Equals(y.ToLower());
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return obj?.ToLower().GetHashCode() ?? 0;
        }
    }
}
