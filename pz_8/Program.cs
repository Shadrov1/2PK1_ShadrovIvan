namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double max = 10.0;
            int i = 0, j = 0;
            int n = 5;
            int m = 5;
            int[,] massiv = new int[n, m];
            Random random = new Random();
            double min = max / 2;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    massiv[i, j] = random.Next(-10, 10);
                    Console.WriteLine(massiv[i, j]);
                    if (massiv[i, j] > 0)
                    {
                        sum = sum + massiv[i, j];

                    }
                    if (massiv[i, j] < min)
                    {
                        min = massiv[i, j];
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(min * sum);
        }
        }
    }
