using System;
using System.Collections.Generic;

namespace QueueInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> queuecustomer = new Queue<Customer>();
            Customer customer1 = new Customer() { Name="Ibrahim",Salary = 4000};
            Customer customer2 = new Customer() { Name="Omar",Salary = 3000};
            Customer customer3 = new Customer() { Name="Amer",Salary = 2000};
            Customer customer4 = new Customer() { Name="Samer",Salary = 1000};
            Customer customer5 = new Customer() { Name="MHD",Salary = 8000};

            queuecustomer.Enqueue(customer1);
            queuecustomer.Enqueue(customer2);
            queuecustomer.Enqueue(customer3);
            queuecustomer.Enqueue(customer4);
            queuecustomer.Enqueue(customer5);

            //Customer c1 = queuecustomer.Dequeue();
            //Console.WriteLine(c1.Name + " - " + c1.Salary);
            //Console.WriteLine("The Total Items in Queue = " + queuecustomer.Count);

            //Customer c2 = queuecustomer.Dequeue();
            //Console.WriteLine(c2.Name + " - " + c2.Salary);
            //Console.WriteLine("The Total Items in Queue = " + queuecustomer.Count);
            
            //Customer c3 = queuecustomer.Dequeue();
            //Console.WriteLine(c3.Name + " - " + c3.Salary);
            //Console.WriteLine("The Total Items in Queue = " + queuecustomer.Count);
            
            //Customer c4 = queuecustomer.Dequeue();
            //Console.WriteLine(c4.Name + " - " + c4.Salary);
            //Console.WriteLine("The Total Items in Queue = " + queuecustomer.Count);

            //Customer c5 = queuecustomer.Dequeue();
            //Console.WriteLine(c5.Name + " - " + c5.Salary);
            //Console.WriteLine("The Total Items in Queue = " + queuecustomer.Count);

            // the first cutomer into queue 
            Customer cFirstOne = queuecustomer.Peek();
            Console.WriteLine("The first cutomer into Queue");
            Console.WriteLine(cFirstOne.Name + " - " + cFirstOne.Salary);
            Console.WriteLine("The Total Items in Queue = " + queuecustomer.Count);

        }
    }

    internal class Customer
    {
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
