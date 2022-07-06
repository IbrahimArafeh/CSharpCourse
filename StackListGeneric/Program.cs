using System;
using System.Collections.Generic;

namespace StackListGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Customer> customerStack = new Stack<Customer>();
            Customer cust1 = new Customer() { id=1,name="Ibrahim",salary=1400};
            Customer cust2 = new Customer() { id=2,name="Arafeh",salary=5000};
            Customer cust3 = new Customer() { id=3,name="Amer",salary=6000};
            Customer cust4 = new Customer() { id=4,name="Omar",salary=8500};

            customerStack.Push(cust1);
            customerStack.Push(cust2);
            customerStack.Push(cust3);
            customerStack.Push(cust4);

            Customer c1 = customerStack.Pop();
            Console.WriteLine(c1.id + " " + c1.name);
            Console.WriteLine("total items in the stack = " + customerStack.Count);

            Customer c2 = customerStack.Peek();
            Console.WriteLine(c2.id + " " + c2.name);
            Console.WriteLine("total items in the stack = " + customerStack.Count);


            if(customerStack.Contains(cust2))
            {
                Console.WriteLine("this customer exist");
            }
            else
            {
                Console.WriteLine("This Coustomer not exist");
            }
        }
    }

    internal class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

    }
}
