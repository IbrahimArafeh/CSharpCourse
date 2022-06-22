using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = Convert.ToInt32(Console.ReadLine()) / Convert.ToInt32(Console.ReadLine());
            }
            catch (UserAleadyLogginException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    [Serializable]
    public class UserAleadyLogginException:Exception
    {
        public UserAleadyLogginException()
        {

        }

        public UserAleadyLogginException(string message):base(message)
        {

        }

        public UserAleadyLogginException(string message,Exception innerException):base(message,innerException)
        {

        }

        public UserAleadyLogginException(SerializationInfo info,StreamingContext contxt):base(info,contxt)
        {

        }
    }
}
