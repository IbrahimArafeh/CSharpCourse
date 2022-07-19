using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStartDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread T1 = new Thread(() => { Number.PrintNumber(); });
            //T1.Start();
            //Object target = Console.ReadLine();
            //Number number = new Number();
            //ParameterizedThreadStart parameterized = new ParameterizedThreadStart(number.printNumber2);
            //Thread T1 = new Thread(number.printNumber2);
            //T1.Start(target);

            // using thread 3
            int target3 = Convert.ToInt32(Console.ReadLine());
            Number2 number2 = new Number2(target3);
            Thread T3 = new Thread(new ThreadStart(number2.printNumber3));
            T3.Start();
        }
    }

    class Number
    {
        public static void PrintNumber()
        {
            for(int i =0; i<=10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void printNumber2(object numbers)
        {
            int outNumber = 0;
            int.TryParse(numbers.ToString(), out outNumber);
            for(int i =0; i<= outNumber; i++)
            {
                Console.WriteLine(i);
            }

        }
    }

    class Number2
    {
        private int _target;
        public Number2(int target)
        {
            this._target = target;
        }

        public void printNumber3()
        {
            for (int i = 0; i < _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
