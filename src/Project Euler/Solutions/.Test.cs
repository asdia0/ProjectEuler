using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public partial class Program
    {
        public static void Test()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}: {Solutions.TriangleNumber(i)}");
            }
        }
    }
}
