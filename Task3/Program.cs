using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {     
            
            for (int i = 1; i <= 5; i++)
            {
                Check ch = new Check();
                ExpInfo[] results = ch.Start(i*10000);
                Console.WriteLine($"Experiment №{i}\r\n");

                Console.WriteLine("<<------Insert------>> \r\n");
                Console.WriteLine($"BinaryHeap: {results[0].InsertTime}\r\n" +
                    $"LinkedList: {results[1].InsertTime}\r\n");
                Console.WriteLine("<<------Extract----->> \r\n");
                Console.WriteLine($"BinaryHeap: {results[0].ExtraxtMaxTime}\r\n" +
                    $"LinkedList: {results[1].ExtraxtMaxTime}\r\n");
                Console.WriteLine("<<------Increase---->> \r\n");
                Console.WriteLine($"BinaryHeap: {results[0].InreaseTime}\r\n" +
                    $"LinkedList: {results[1].InreaseTime}\r\n");
                Console.WriteLine("*****================================================****\r\n");
            }
            Console.WriteLine("---------------END---------------");
            Console.ReadLine();
        }
    }
}
