using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestApp
{
    public class Logic
    {
        /// <summary>
        /// Square number of element 'a'
        /// </summary>
        /// <param name="a"></param>
        public static void sqrtElem(int a)
        {
            int result = a * a;

            Console.WriteLine(result);
        }

        /// <summary>
        /// Square number of element 'a' raised to the power 'b'
        /// </summary>
        /// <param name="a"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int sqrtElem(int a, int p)
        {
            return (int)Math.Pow(a, p);
        }

        public static int sqrtElem(int a, int p, int b = 1)
        {
            return (int)Math.Sqrt(a + p + b);
        }
    }
}
