namespace ProjectEuler
{
    public partial class Solutions
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=15">Project Euler: Problem 15</see>
        /// </summary>
        /// <returns>137846528820</returns>
        public static long Problem15()
        {
            long[,] plane = new long[21, 21];

            plane[0, 0] = 1;

            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (i == 0)
                    {
                        plane[i, j] = 1;
                    }
                    else if (j == 0)
                    {
                        plane[i, j] = 1;
                    }
                    else
                    {
                        plane[i, j] = plane[i - 1, j] + plane[i, j - 1];
                    }
                }
            }

            return plane[20, 20];
        }
    }
}
