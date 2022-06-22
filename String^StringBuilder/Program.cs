using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(System.DateTime.Now.ToUniversalTime().Millisecond);
            string text1 = "C#";
            text1 += " is a good language";
            text1 += " it used to complete all type of programming";
            Console.WriteLine(System.DateTime.Now.ToUniversalTime().Millisecond);
            Console.WriteLine(text1);

            Console.WriteLine("---------------------");

            Console.WriteLine(System.DateTime.Now.ToUniversalTime().Millisecond);
            StringBuilder userString = new StringBuilder("C#");
            userString.Append(" is a good language ");
            userString.Append("it used to complete all type of programming");
            Console.WriteLine(System.DateTime.Now.ToUniversalTime().Millisecond);
            Console.WriteLine(userString);

        }
    }
}
