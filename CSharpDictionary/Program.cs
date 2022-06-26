using System;
using System.Collections.Generic;

namespace CSharpDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { id = 1, Age = 10, Name = "Ibrahim" };
            Customer customer2 = new Customer() { id = 2, Age = 40, Name = "Amer" };
            Customer customer3 = new Customer() { id = 3, Age = 60, Name = "samer" };
            Customer customer4 = new Customer() { id = 4, Age = 100, Name = "mazen" };

            Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
            customerDictionary.Add(101, customer1);
            customerDictionary.Add(4981, customer2);
            customerDictionary.Add(9983, customer3);
            customerDictionary.Add(5574, customer4);

            if (!customerDictionary.ContainsKey(customer4.id))
            {
                customerDictionary.Add(4, customer4);
            }

            Customer cutomer = customerDictionary[5574];
            Console.WriteLine("the customer information called by key are : ID = {0} Name = {1} Age = {2}", cutomer.id, cutomer.Name, cutomer.Age);

            foreach(KeyValuePair<int,Customer> dictionaryItem in customerDictionary)
            {
                Console.WriteLine("Key =" + dictionaryItem.Key);
                Customer cust = dictionaryItem.Value;
                Console.WriteLine("ID = {0} Name= {1} Age = {2}", cust.id, cust.Name, cust.Age);
            }
        }

        
    }
    internal class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
