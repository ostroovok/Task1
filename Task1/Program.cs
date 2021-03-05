using System;

namespace Task1
{
    class Program
    {
        private static Random _rnd;
        static void Main(string[] args)
        {
            _rnd = new Random();
            Experiment(100000);
        }

        public static void Experiment(int size)
        {
            for (int i = 1; i <= 10; i++)
            {
                double midTime = 0;
                for (int j = 0; j < 10; j++)
                {
                    int[] arr = Generate(i * size, 50);
                    midTime += WorkWithArray.Solve(arr);
                }
                Console.WriteLine($"Size: {i * size}, Time: {midTime / 10}");
                Console.WriteLine("-------------------");
            }
            Console.ReadLine();
        }

        public static int[] Generate(int size, int max)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = _rnd.Next(0, max);
            }
            return arr;
        }
    }
}
