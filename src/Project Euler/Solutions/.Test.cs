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
            decimal d = decimal.Divide(1, 6);
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString()[1]);
        }
    }
}
