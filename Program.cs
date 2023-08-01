using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestApp
{
    internal class Program : Logic 
    {
        /// <summary>
        /// Sum three elements (a,b,c)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static void sumElem(int a, int b)
        {
            int c = a + b;

            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} * {a} = {a * a}");

            sumElem(3, 1);

            Logic appLogic = new Logic();
            appLogic.sqrtElem(3);

            Console.WriteLine("'World Hello' App");

            Console.WriteLine("Hello world!");
        }
    }
}
