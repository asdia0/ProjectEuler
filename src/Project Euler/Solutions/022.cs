namespace ProjectEuler
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=22">Project Euler: Problem 22</see>
        /// </summary>
        /// <returns>850081394</returns>
        public static long Problem22()
        {
            long sum = 0;

            List<string> source = JsonConvert.DeserializeObject<List<string>>(File.ReadAllText("Resources/022.txt"));

            source.Sort();

            for (int i = 0; i < source.Count; i++)
            {
                long nameCount = 0;

                foreach (char c in source[i])
                {
                    nameCount += char.ToUpper(c) - 64;
                }

                sum += nameCount * (i + 1);
            }

            return sum;
        }
    }
}
