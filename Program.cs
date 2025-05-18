using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestApp
{
    class Program : Logic 
    {
        public static void sumElem(int a, int b)
        /// <summary>
        /// Sum three elements (a,b,c)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static void sumElem(int a, int b, int c)
        {
            int d = a + b + 1;

            Console.WriteLine(d);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is a clone of project from GitHub repository!!");

            Console.Write("\nEnter your number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} * {a} = {a * a}");

            sumElem(2, 3);

            Console.WriteLine("'World Hello' App");

            Console.WriteLine("NewBranch1 branch");
            Console.Write("\nsumElem method result: ");
            sumElem(3, 1, 3);

            Console.Write("\nsqrtElem method result: ");
            sqrtElem(3);
            Console.WriteLine("\nBranchFromMain created!");
        }
    }
}
