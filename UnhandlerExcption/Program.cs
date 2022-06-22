using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnhandlerExcption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"C:\Projects\CSharpCourse\UnhandlerExcption\files\file.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("please check if the file {0} exsits ", ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
    }
}
