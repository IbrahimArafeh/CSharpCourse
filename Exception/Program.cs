using System;


namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first Number : ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second Number : ");
                int y = Convert.ToInt32(Console.ReadLine());

                int z = x / y;
                Console.WriteLine(z);
                Console.WriteLine();
                Console.WriteLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("Please Enter Digit Only...");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Please Enter non zero digit...");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Please Enter Digit between {0} and {1}",Int32.MaxValue,Int32.MinValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
