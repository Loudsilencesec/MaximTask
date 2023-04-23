﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaximTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string notvalid;
            while (true)
            {

                input = Console.ReadLine();
                notvalid = task2(input);


                if (notvalid.Length == 0)
                {
                    Console.WriteLine(task1(input));
                }
                else
                {

                    Console.WriteLine("Вы используете недопустимые символы: " + notvalid);

                }
            }

        }

        static string task1(string str)
        {
            if (str.Length % 2 == 0)
            {
                string half1 = str.Substring(0, str.Length /2);
                string life2 = str.Substring(str.Length /2);

                half1 = new string(half1.Reverse().ToArray());
                life2 = new string(life2.Reverse().ToArray());

                return half1 + life2;
            }

            string reversstr = new string(str.Reverse().ToArray());

            return reversstr + str;
            
        }
        static void task3(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }

            Console.WriteLine("Количество повторений каждого символа в строке:");
            foreach (KeyValuePair<char, int> kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
}   }
