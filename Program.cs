using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestApp
{
    internal class Program : Logic 
    {
        public void sumElem(int a, int b)
        {
            int c = a + b;

            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} * {a} = {a * a}");

            Program elem = new Program();
            elem.sumElem(2, 3);

            Logic appLogic = new Logic();
            appLogic.sqrtElem(3);

            Console.WriteLine("'World Hello' App");
        }
    }
}
