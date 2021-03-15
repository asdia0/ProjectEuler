namespace ProjectEuler
{
    using System;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=40">Project Euler: Problem 40</see>
        /// </summary>
        /// <returns>210</returns>
        public static long Problem40()
        {
            string s = "0";
            int i = 0;

            while (s.Length < 1000001)
            {
                i++;
                s += i;
            }

            return int.Parse(s[10].ToString()) *
                int.Parse(s[100].ToString()) *
                int.Parse(s[1000].ToString()) *
                int.Parse(s[10000].ToString()) *
                int.Parse(s[100000].ToString()) *
                int.Parse(s[1000000].ToString());
        }
    }
}
