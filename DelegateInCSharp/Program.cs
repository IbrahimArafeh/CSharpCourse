using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInCSharp
{
    public delegate void SampleDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethod1);
            del = SampleMethod2;
            del();

        }

        public static void SampleMethod1()
        {
            Console.WriteLine("This is the first Method");
        }

        public static void SampleMethod2()
        {
            Console.WriteLine("This is the Second One Method");
        }
    }
}
