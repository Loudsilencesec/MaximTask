using System;
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
            string input = Console.ReadLine();
            Console.WriteLine(task1(input));

        }

        static string task1(string str)
        {
            if (str.Length % 2 == 0)
            {
                string half1 = str.Substring(0, str.Length / 2);
                string life2 = str.Substring(str.Length / 2);

                half1 = new string(half1.Reverse().ToArray());
                life2 = new string(life2.Reverse().ToArray());

                return half1 + life2;
            }

            string reversstr = new string(str.Reverse().ToArray());

            return reversstr + str;
            
        }
    }
}
