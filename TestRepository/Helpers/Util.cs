using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestRepository.Helpers
{
    public static class Util
    {
        public static string GetIdentifier()
        {
            return Util.GetRandomString(8, "0123456789ABCDEFGHIJKLMNOPQRSTUVXWYZabcdefghijklmnopqrstuvxwyz");
        }

        public static String GetRandomString(int len, string strChars = null)
        {
            if (String.IsNullOrEmpty(strChars))
                strChars = "abcdefghijklmnopqrstuvxwyz0123456789";
            var r = new Random();
            var sb = new StringBuilder();
            for (var x = 0; x < len; x++)
                sb.Append(strChars[r.Next(0, strChars.Length - 1)]);
            return sb.ToString();
        }

        public static string Concat<t>(this IEnumerable<t> lst, Func<t, object> valueFunction, string separator = ", ", string format = null, string defaultValue = null, bool distinct = true)
        {
            if (lst == null || lst.Count() == 0)
                return defaultValue;
            var newlst = (distinct ? lst.Select(item => valueFunction(item)).Distinct() : lst.Select(item => valueFunction(item))).ToList();
            var str = new StringBuilder();
            foreach (var value in newlst)
            {
                var valuestr = Convert.ToString(value);
                if (!string.IsNullOrEmpty(valuestr))
                    str.Append(string.IsNullOrEmpty(format) ? valuestr + separator : string.Format("{0:" + format + "}", value) + separator);
            }
            return string.IsNullOrEmpty(str.ToString()) ? null : str.Remove(str.Length - separator.Length, separator.Length).ToString();
        }
    }
}
