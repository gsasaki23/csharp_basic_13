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
            // LoopArray(intArray);
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Five:");
            // FindMax(intArray);
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Six:");
            // GetAverage(intArray);
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Seven:");
            // OddArray();
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Eight:");
            // Console.WriteLine(GreaterThanY(intArray,3));
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Nine:");
            // Console.WriteLine("Before: " + intArray[1]);
            // SquareArrayValues(intArray);
            // Console.WriteLine("After: " + intArray[1]);
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Ten:");
            // int[] testTen = {1,-2,3,-4,5};
            // Console.WriteLine("Before: " + testTen[1] + " expecting -2");
            // EliminateNegatives(testTen);
            // Console.WriteLine("After: " + testTen[1] + " expecting 0");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Eleven:");
            int[] testEleven = {1,-2,3,-4,5};
            Console.WriteLine("Expecting max:5, min:-4, avg:0.66");
            MinMaxAverage(testEleven);
            
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task Twelve:");
            
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
            if (numbers.Length == 0) {return 0;}

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max){
                    max = number;
                }
            }
            Console.WriteLine(max);
            return max;
        }
        
        public static int GetAverage(int[] numbers)
        // 6: iterate int[] and print/return AVG value
        {
            if (numbers.Length == 0) {return 0;}

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            int avg = sum / numbers.Length;
            Console.WriteLine(avg);
            return avg;
        }
    
        public static List<int> OddArray()
        // 7: Create array with odds 1~255
        // *** Will use list instead of array, since the size will need to be dynamic. Might be wrong ***
        {
            List<int> intList = new List<int>();
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0){
                    intList.Add(i);
                }
            }
            return intList;
        }

        public static int GreaterThanY(int[] numbers, int y)
        // 8: Given int array and int y, return # of array vals greater than y
        {
            int answer = 0;
            foreach (var number in numbers)
            {
                if (number > y){
                    answer ++;
                }
            }
            return answer;
        }

        public static void SquareArrayValues(int[] numbers)
        // 9: Given int array, multiply each val by itself
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            return;
        }
    
        public static void EliminateNegatives(int[] numbers)
        // 10: Given int array, replace numbers < 0 with 0
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0){
                    numbers[i] = 0;
                }
            }
            return;
        }

        public static void MinMaxAverage(int[] numbers)
        // 11: Given int array, print max, min, and avg
        {
            if (numbers.Length == 0) {return;}

            int sum = 0;
            int max = numbers[0];
            int min = numbers[0];
            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }
            double avg = (double) sum / numbers.Length;
            Console.WriteLine($"max:{max}, min:{min}, avg:{avg}");
            return;
        }
    

    
    
    }
}
