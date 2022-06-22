using System;


namespace Session1
{
    internal class Program
    {
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string username;
            int number;

            Console.WriteLine("Enter you name ");
            username = Console.ReadLine();

            Console.WriteLine("Enter YOur number :");
            number = Convert.ToInt32(Console.ReadLine());

            if(number < 10)
            {
                Console.WriteLine("this student is faild");
            }
            string external = "ever";

            Console.WriteLine("You Name is :" + username + " " + number + " " + external);
            Console.ReadKey(); 
        }
    }
}