using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlerAbuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = Convert.ToInt32(Console.ReadLine()) / Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Insert Digit only ..");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please Insert Digit between {0} and {1}",Int32.MinValue,Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Don't insert 0 digit in Denominator...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
