using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Commun
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the input string with the first character converted to uppercase
        /// </summary>
        public static string Capitalize(this string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentException("There is no first letter");

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

    }
}
