namespace ProjectEuler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=66">Project Euler: Problem 66</see>
        /// </summary>
        /// <returns>661</returns>
        public static BigInteger Problem66()
        {
            Dictionary<BigInteger, BigInteger> res = new Dictionary<BigInteger, BigInteger>();

            for (int z = 1; z <= 1000; z++)
            {
                if (Math.Sqrt(z) % 1 == 0)
                {
                    continue;
                }

                // CONTINUED FRACTION
                long m = (long)Math.Floor(Math.Sqrt(z));

                bool first = true;
                long a = 1;
                long b = m;

                List<long> continuedfracs = new List<long>
                {
                    m
                };

                while (first == true || a > 1)
                {
                    a = (long)Math.Floor(decimal.Divide(z - b * b, a));
                    continuedfracs.Add((long)Math.Floor(decimal.Divide(m + b, a)));
                    b = m - (m + b) % a;
                    first = false;
                }

                BigInteger y = 0;
                BigInteger x = 0;

                List<BigInteger> h = new List<BigInteger>()
                {
                    0, 1
                };
                List<BigInteger> k = new List<BigInteger>()
                {
                    1, 0
                };

                int n = 0;
                int period = continuedfracs.Count - 1;

                while (x * x - z * y * y != 1)
                {
                    // CONVERGENT
                    if (n > period)
                    {
                        continuedfracs.Add(continuedfracs[n - period]);
                    }
                    h.Add(continuedfracs[n] * h[^1] + h[^2]);
                    k.Add(continuedfracs[n] * k[^1] + k[^2]);

                    x = h[^1];
                    y = k[^1];

                    n++;
                }

                res.Add(z, x);
            }

            return (long)res.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }
    }
}
