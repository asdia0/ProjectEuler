namespace ProjectEuler
{
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=20">Project Euler: Problem 20</see>
        /// </summary>
        /// <returns>648</returns>
        public static long Problem20()
        {
            long sum = 0;

            BigInteger fact = Factorial(100);

            string sfact = fact.ToString();

            foreach (char c in sfact)
            {
                sum += long.Parse(c.ToString());
            }

            return sum;
        }
    }
}
