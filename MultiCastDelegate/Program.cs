using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public delegate void SampleDelegate();
    public delegate void SampleDeletgate2(out int IntegerValue);
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del -= SampleMethodTwo;
            del += SampleMethodOne;
            del();

            // when we have MultiCast Delegate that mean last one will be executed
            SampleDeletgate2 del2 = new SampleDeletgate2(SampleMethodThree);
            del2 += SampleMethodFour;

            int deletgateOutputParamerterValue = -1;
            del2(out deletgateOutputParamerterValue);

            Console.WriteLine("Return Value = {0}", deletgateOutputParamerterValue);
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("This is the 1111 Method");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("This is the 22222 One Method");
        }

        public static void SampleMethodThree(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethodFour(out int Number)
        {
            Number = 2;
        }
    }
}
