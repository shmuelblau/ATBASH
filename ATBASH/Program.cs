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
            string output =string.Join("", input.Select(x => char.ToLower(x)).Select(s => (char)((int)s + ((103 - (int)s) * 2))).ToArray());
            string[] a = output.Split(',');
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(conversion("azaz"));
            
        }
    }
}
