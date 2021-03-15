namespace ProjectEuler
{
    using System;
    using System.IO;
    using System.Text.Json;
    using System.Collections.Generic;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=42">Project Euler: Problem 42</see>
        /// </summary>
        /// <returns>162</returns>
        public static int Problem42()
        {
            int counter = 0;

            List<string> words = JsonSerializer.Deserialize<List<string>>("[" + File.ReadAllText("Resources/042.txt") + "]");

            foreach (string word in words)
            {
                int count = 0;

                foreach (char c in word)
                {
                    count += char.ToUpper(c) - 64;
                }

                if (IsTriangular(count))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
