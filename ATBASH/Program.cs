using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH
{
    internal class Program
    {
        
        public static string conversion(string input)
        {
            return string.Join("", input.Select(x => char.ToLower(x)).Select(s =>char.IsLetter(s) ? (char)((int)s + ((109 - (int)s) * 2)+1) : s).ToArray());
            
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(conversion("nop "));
            
        }
    }
}
