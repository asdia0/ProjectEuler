using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    using System.Text.Json;
    public partial class Program
    {
        public static void Test()
        {
            Console.WriteLine(JsonSerializer.Serialize(Solutions.GeneratePrimes(100)));
        }
    }
}
