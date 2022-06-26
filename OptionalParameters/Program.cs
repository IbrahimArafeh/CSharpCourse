using System;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = SumNumbers(100, 30, 20, 20, 20, 40);
            Console.WriteLine(result);
        }

        private static int SumNumbers(int number1,int number2,params object[] manyNumbers)
        {
            int result = number1 + number2;
            foreach(int m in manyNumbers)
            {
                result += m;
            }

            return result; 
        }
    }
}
