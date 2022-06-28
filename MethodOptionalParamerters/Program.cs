using System;
using System.Runtime.InteropServices;

namespace MethodOptionalParamerters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumNumbers(2, 2, null);
            SumNumbers2(1,2,2);
            SumNumbers2(1,z:2);
           
        }

        public static void SumNumbers(int number_1,int number_2, int[] numbers )
        {
            int result = number_1 + number_2;
            if(numbers !=null)
            {
                foreach(int number in numbers)
                {
                    result += number;
                }
            }
            Console.WriteLine(result);
        }
        public static void SumNumbersOptionalParamerters(int number_1,int number_2,[Optional] int[] numbers )
        {
            int result = number_1 + number_2;
            if(numbers !=null)
            {
                foreach(int number in numbers)
                {
                    result += number;
                }
            }
            Console.WriteLine(result);
        }

     
        // using optional attribute
        public static void SumNumbers2(int x,int y=2, int z=1)
        {
            int result = x + y + z;
            Console.WriteLine(result);
        }
    }
}
