using System;
using System.Threading;

namespace ThreadUsingSafeManner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the to count to it");
            int target = Convert.ToInt32(Console.ReadLine());
            customer cut = new customer(target);

            //Thread T = new Thread(new ThreadStart(cut.printNumbers));
            Thread T = new Thread(cut.printNumbers); // other type
            T.Start();
        }
    }

    internal class customer
    {
        private int _Target;
        public customer(int target)
        {
            _Target = target;
        }

        public void printNumbers()
        {
            for(int i= 0; i < _Target; i++)
            {
                Console.WriteLine(i);   
            }
        }
    }
}
