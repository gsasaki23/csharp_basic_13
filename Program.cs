using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task One:");
            // PrintNumbers();

            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Two:");
            // PrintOdds();
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Three:");
            // PrintSum();
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Four:");
            int[] intArray = {1,2,3,4,5};
            LoopArray(intArray);
        }

        public static void PrintNumbers()
        // 1: Print 1-255
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void PrintOdds()
        // 2: Print 1-255 odds
        {
            for(int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
        }
    
        public static void PrintSum()
        // 3: Print 1-255, but with sum as you go
        {
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
            int sum = 0;
            for(int i = 1; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }
    
        public static void LoopArray(int[] numbers)
        // 4: iterate int[] and print each value
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static int FindMax(int[] numbers)
        // 5: iterate int[] and print/return max value
        {
            int max = 0;
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            return answer;
        }
    
    }
}
