using System;
using System.Threading;
using static RetrievingDataUsingCallBackMethod.Program;

namespace RetrievingDataUsingCallBackMethod
{
    internal class Program
    {
        public delegate void sumOfNumberCallBack(int sumOfNumbers);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mumber to sum");
            int target = Convert.ToInt32(Console.ReadLine());

            sumOfNumberCallBack callBackMethod = new sumOfNumberCallBack(printSumOfNumbers);
            customer customer = new customer(target,callBackMethod);
            Thread T = new Thread(new ThreadStart(customer.computeSumOfNumbers));
            T.Start();
        }

        public static void printSumOfNumbers(int sum)
        {
            Console.WriteLine("Sum of Number is: " + sum);
        }
    }

    internal class customer
    {
        private int _target;
        sumOfNumberCallBack _callBackMethod;

        public customer(int target,sumOfNumberCallBack sumOfNumberCallBack)
        {
            _target = target;
            _callBackMethod = sumOfNumberCallBack; 
        }

        public void computeSumOfNumbers()
        {
            int sum = 0;
            for(int i = 1; i <= _target; i++)
            {
                sum = sum + i;
            }

            if (_callBackMethod != null)
                _callBackMethod(sum);
        }

    }
}
