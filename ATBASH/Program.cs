﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATBASH
{
    internal class Program
    {

        
        public static string conversion(string input)
        {
            return string.Join("", input.Select(x => char.ToLower(x)).Select(s =>char.IsLetter(s) ? (char)((int)s + ((109 - (int)s) * 2)+1) : s).ToArray());
            
            
        }
       

        static int Number_of_points(string txt , string[] suspicious_words)
        {
            int points = 0;
            
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
        static void Print_message(int points) 
        {
            if (points > 1 && points <= 5)
            {
                Console.WriteLine("----warning----");
                Console.WriteLine($"The number of points is:{points} ");
            }
            else if (points >= 6 && points <= 10)
            {
                Console.WriteLine("----danger!!!----");
                Console.WriteLine($"The number of points is:{points} ");
            }
            else if (points >= 11 && points <= 15)
            {
                Console.WriteLine("----High alert!!!----");
                Console.WriteLine($"The number of points is:{points} ");
            }
            else if(points > 15) 
            {
                Console.WriteLine("----Very high alert!!!----");
            }
            {
                
            }
        }

        static void Main(string[] args)
        {
            string msg;
            string[] words;
            try
            {
                msg = File.ReadAllText(args[0]);
                words = File.ReadAllText(args[1]).Split(" ");
            }
            catch { 

                return;
            }

            string DecryptedText = conversion(msg);

            int sum = Number_of_points(DecryptedText , words);

            Console.WriteLine(DecryptedText);
            
            Print_message(sum);

        }
    }
}
