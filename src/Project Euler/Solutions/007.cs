namespace ProjectEuler
{
    using System.Linq;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=7">Project Euler: Problem 7</see>
        /// </summary>
        /// <returns>104743</returns>
        public static long Problem7()
        {
            return GetPrimes(10001).Last();
        }
    }
}
