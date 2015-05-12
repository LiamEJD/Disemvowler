using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvowel
{
    public static class Disemvowel
    {
        public static string[] Replace(string s, char[] seperators)
        {
            string removed = "";
            foreach (char c in s)
            {
                for (int i = 0; i < seperators.Count(); i++)
                {
                    if (c == seperators[i])
                    {
                        removed += c;
                    }
                }
            }
            string output = string.Concat(s.Split(seperators));
            string[] result = {output, removed};
            return result;
        }
    }
}
