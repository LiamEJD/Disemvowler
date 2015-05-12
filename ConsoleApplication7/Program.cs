using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Disemvowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter original sentence: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter characters to be removed (including a space character if needed): ");
            string delimeter = Console.ReadLine();
            char[] seperator = delimeter.ToCharArray();
            string[] results = Disemvowel.Replace(text, seperator);
            Console.WriteLine("New sentence: {0}\nCharacters removed: {1}", results[0], results[1]);
        }
    }
}
