using System;
using System.Collections.Generic;
using System.Linq;

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


            // TryGetValue Method in Dictionary
            Customer custo;
            if(customerDictionary.TryGetValue(4981, out custo))
            {
                Console.WriteLine();
                Console.WriteLine("The Result of TryGetValue Method");
                Console.WriteLine("Id= {0} Name= {1}  Age= {2}", customer1.id, customer1.Name, customer1.Age);
            }
            else
            {
                Console.WriteLine("the value not exsit");
                Console.WriteLine();
            }


            /// Count Method in Dictionary
            Console.WriteLine();
            Console.WriteLine("The Result of Count Method in Dictionary is {0}", customerDictionary.Count(c=>c.Value.Age>40));
            Console.WriteLine();


            // Remove Funtion
            Console.WriteLine("Result after Using Remove Function that delet Mazen Record");
            Console.WriteLine();
            customerDictionary.Remove(9983);
            foreach(Customer cust1 in customerDictionary.Values)
            {
                Console.WriteLine("ID = {0} Name={1} Age={2}", cust1.id, cust1.Name, cust1.Age);
                Console.WriteLine();
            }


            // Clear Funtion in Dictionary
            Console.WriteLine("Result after Using Clear Function ");
            Console.WriteLine();
            customerDictionary.Clear();
            foreach (Customer cust1 in customerDictionary.Values)
            {
                Console.WriteLine("ID = {0} Name={1} Age={2}", cust1.id, cust1.Name, cust1.Age);
                Console.WriteLine();
            }

            // change array to dictionary
            Console.WriteLine();
            Console.WriteLine("Change array to Dictionary");
            Console.WriteLine();
            Customer[] customerArray = new Customer[3];
            customerArray[0] = customer1;
            customerArray[1] = customer2;
            customerArray[2] = customer3;

            Dictionary<int, Customer> customerDictionary2 = customerArray.ToDictionary(cup => cup.id, cup => cup);
            foreach(KeyValuePair<int,Customer>kvp in customerDictionary2)
            {
                Console.WriteLine("The Key : {0}", kvp.Key);
                Customer cust12 = kvp.Value;
                Console.WriteLine("ID = {0} Name={1} Age= {2}", cust12.id, cust12.Name, cust12.Age);
            }

            // change List to dictionary
            Console.WriteLine();
            Console.WriteLine("Change List to Dictionary");
            Console.WriteLine();
            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);

            Dictionary<int, Customer> customerDictionary3 = customerArray.ToDictionary(cup => cup.id, cup => cup);
            foreach (KeyValuePair<int, Customer> kvp in customerDictionary3)
            {
                Console.WriteLine("The Key : {0}", kvp.Key);
                Customer cust12 = kvp.Value;
                Console.WriteLine("ID = {0} Name={1} Age= {2}", cust12.id, cust12.Name, cust12.Age);
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
