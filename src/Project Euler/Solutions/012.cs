namespace ProjectEuler
{
    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=12">Project Euler: Problem 12</see>
        /// </summary>
        /// <returns>76576500</returns>
        public static long Problem12()
        {
            int number = 0;
            int i = 1;

            while (GetNumberOfFactors(number) < 500)
            {
                number += i;
                i++;
            }

            return number;
        }
    }
}
