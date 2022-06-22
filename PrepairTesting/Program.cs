using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepairTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 9;
           int result =  getNumRef(ref j);
            Console.WriteLine("the result is : " + result);
            Console.ReadKey();

            int[] num = new int[3];
            num[0] = 10;
            num[1] = 100;
            num[2] = 104;

            getParamArray(num);
            Console.ReadKey();
        }

        public static int getNumRef(ref int j)
        {
            j = 100;
            return j;
        }

        public static void getParamArray(params int [] numbers)
        {
            Console.WriteLine("the array length is {0}", numbers.Length);
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
