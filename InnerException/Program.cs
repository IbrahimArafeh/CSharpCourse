using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InnerException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("please Insert First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please Insert Second Number: ");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    double Result = FN / SN;
                    Console.WriteLine("the result is : {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Projects\CSharpCourse\InnerException\file\lsog.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.WriteLine();
                        sw.Close();
                        Console.WriteLine("please check on log file to declare the problem");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present ", ex);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception {0}", exception.GetType().Name);
                Console.WriteLine("Current Exception {0}", exception.InnerException.GetType().Name);
            }
           
        }
    }
}
