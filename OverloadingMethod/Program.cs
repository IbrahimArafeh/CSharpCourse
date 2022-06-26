using System;

namespace OverloadingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sumNumber(12, 16,new int[] {30,59}); 
        }

        private static void sumNumber(int Number_1, int Number_2, int[] numbers)
        {
            int result = Number_1 + Number_2;
            if(numbers.Length>0)
            {
                foreach (int number in numbers)
                {
                    result += number;
                }
            }
            Console.WriteLine(result);
        }

        private static void sumNumber(int Number_1, int Number_2)
        {
            sumNumber(Number_1, Number_2, null);
        }
    }
}
