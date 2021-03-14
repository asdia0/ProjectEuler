namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=32">Project Euler: Problem 32</see>
        /// </summary>
        /// <returns>45228</returns>
        public static long Problem32()
        {
            List<int> l = new List<int>();

            for (int a = 1; a < 9; a++)
            {
                for (int b = 999; b < 9999; b++)
                {
                    string ab = $"{a}{b}{a * b}";
                    if (!l.Contains(a * b) && ab.Count() == 9 && IsPandigital(int.Parse(ab)))
                    {
                        l.Add(a * b);
                    }
                }
            }

            for (int a = 9; a < 99; a++)
            {
                for (int b = 99; b < 999; b++)
                {
                    string ab = $"{a}{b}{a * b}";
                    if (!l.Contains(a * b) && ab.Count() == 9 && IsPandigital(int.Parse(ab)))
                    {
                        l.Add(a * b);
                    }
                }
            }

            return l.Sum();
        }
    }
}
