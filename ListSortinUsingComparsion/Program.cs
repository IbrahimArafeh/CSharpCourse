using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSortinUsingComparsion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { id = 1, name = "Ibrahim", salary = 5000 };
            Customer customer2 = new Customer() { id = 2, name = "arafe", salary = 3000 };
            Customer customer3 = new Customer() { id = 3, name = "amer", salary = 9000 };
            Customer customer4 = new Customer() { id = 4, name = "omar", salary = 2300 };

            List<Customer> customerList = new List<Customer>(100);
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);
            Console.WriteLine("1 ------The List of salary before sorting");
            foreach(Customer item in customerList)
            {
                Console.WriteLine(item.salary);
            }
            Comparison<Customer> comparison = new Comparison<Customer>(customerCompairsion);
            customerList.Sort(comparison);
            Console.WriteLine();
            Console.WriteLine("2 ------The List of salary After sorting");
            foreach (Customer item in customerList)
            {
                Console.WriteLine(item.salary);
            }
            Console.WriteLine();
            Console.WriteLine("3 ------The List of salary After sorting using delegate in same methond");
            customerList.Sort(delegate (Customer x, Customer y) { return (x.salary.CompareTo(y.salary)); });
            foreach (Customer item in customerList)
            {
                Console.WriteLine(item.salary);
            }
            Console.WriteLine();
            Console.WriteLine("4 ------The List of salary After sorting using lambda expression");
            customerList.Sort((c1,c2)=> c1.salary.CompareTo(c2.salary));
            foreach (Customer item in customerList)
            {
                Console.WriteLine(item.salary);
            }

            Console.WriteLine();
            Console.WriteLine("5 ------define a read only List using AsReadOnly() Method ----");
            IReadOnlyCollection<Customer> readOnlyCustomerList = customerList.AsReadOnly();
            Console.WriteLine("The Items numbers into Customerlist is : {0}", readOnlyCustomerList.Count);

            Console.WriteLine();
            Console.WriteLine("6 ------using TrueForAll() Method ----");
            Console.WriteLine("The result of query which all salary greater than 5000 = " 
                + customerList.TrueForAll(c => c.salary > 5000));

            Console.WriteLine();
            Console.WriteLine("6 ------using TrueForAll() Method ----");
            Console.WriteLine("The result of query which all salary greater than 2000 = " 
                + customerList.TrueForAll(c => c.salary > 2000));


            Console.WriteLine();
            Console.WriteLine("7 ------using TrimExcess() Method ----");
            Console.WriteLine("The Capacity of List before using TrimExcess is : " + customerList.Capacity);
            customerList.TrimExcess();
            Console.WriteLine("The Capacity of List After using TrimExcess is : " + customerList.Capacity);
            

        }


        public static int customerCompairsion(Customer x, Customer y)
        {
            return x.salary.CompareTo(y.salary);
        }
    }

    internal class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

    }
}
