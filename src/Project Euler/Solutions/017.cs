namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=17">Project Euler: Problem 17</see>
        /// </summary>
        /// <returns>21124</returns>
        public static long Problem17()
        {
            Dictionary<int, string> digitToLetter = new Dictionary<int, string>
            {
                { 0, string.Empty },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
            };

            Dictionary<int, string> tensToLetter = new Dictionary<int, string>
            {
                { 0, string.Empty },
                { 2, "twenty" },
                { 3, "thirty" },
                { 4, "forty" },
                { 5, "fifty" },
                { 6, "sixty" },
                { 7, "seventy" },
                { 8, "eighty" },
                { 9, "ninety" },
            };

            Dictionary<int, string> tenToTwenty = new Dictionary<int, string>
            {
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fifteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" },
            };

            long totLen = 0;

            for (int i = 1; i <= 1000; i++)
            {
                string snum = i.ToString();

                // 1 - 9
                if (snum.Length == 1)
                {
                    totLen += digitToLetter[i].Length;
                }

                // 10 - 99
                if (snum.Length == 2)
                {
                    // 10 - 19
                    if (snum[0] == '1')
                    {
                        totLen += tenToTwenty[i].Length;
                    }

                    // 20 - 99
                    else
                    {
                        totLen += tensToLetter[int.Parse(snum[0].ToString())].Length + digitToLetter[int.Parse(snum[1].ToString())].Length;
                    }
                }

                // 100 - 999
                if (snum.Length == 3)
                {
                    // only have "and" if is not a multiple of 100
                    if (i % 100 != 0)
                    {
                        totLen += 3;
                    }

                    // x
                    totLen += digitToLetter[int.Parse(snum[0].ToString())].Length + 7;

                    // x10 - x19
                    if (snum[1] == '1')
                    {
                        totLen += tenToTwenty[int.Parse(snum[1].ToString() + snum[2].ToString())].Length;
                    }

                    // x20 - x99
                    else
                    {
                        totLen += tensToLetter[int.Parse(snum[1].ToString())].Length + digitToLetter[int.Parse(snum[2].ToString())].Length;
                    }
                }

                // 1000
                else if (snum.Length == 4)
                {
                    totLen += 11;
                }
            }

            return totLen;
        }
    }
}
