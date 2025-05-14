using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
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
       

        static int Number_of_points(string txt)
        {
            int points = 0;
            string[] suspicious_words = {"bomb", "nukhba", "fighter", "rocket", "secret"};
            foreach (var word in txt.Split(" "))
            {
                foreach(var Suspicious_word in suspicious_words)
                {
                    if (word == Suspicious_word)
                    {
                        points++;
                    }
                }
            }
            return points;
        }
        static void Main(string[] args)
        {

            
        }
    }
}
