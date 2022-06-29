using System;
using System.Collections.Generic;

namespace CsharpList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sorting Numbers List
            List<int> NumberList = new List<int>() {10,12,3,5,56,1,0,1,3,33,99};
            NumberList.Sort();
            foreach(int i in NumberList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Sorting String List
            List<string> stringList = new List<string>() { "Ibrahim","Amer","MHD","L","M","A"};
            stringList.Sort();
            foreach (string i in stringList)
            {
                Console.WriteLine(i);
            }

            Customer customer1 = new Customer() { Name="Ibrahim", Salary=5000};
            Customer customer2 = new Customer() { Name="Omar", Salary=2000};
            Customer customer3 = new Customer() { Name="Amer", Salary=9000};
            Customer customer4 = new Customer() { Name="Firas", Salary=5000};
            Customer customer5 = new Customer() { Name="MHD", Salary=2000};

            List<Customer> customerlist = new List<Customer>();
            customerlist.Add(customer1);
            customerlist.Add(customer2);
            customerlist.Add(customer3);
            customerlist.Add(customer4);
            customerlist.Add(customer5);

            Console.WriteLine();
            Console.WriteLine("Array before sorting");
            foreach (Customer i in customerlist)
            {
                Console.WriteLine(i.Salary);
            }

            Console.WriteLine();
            Console.WriteLine("Array After sorting");
            customerlist.Sort();

            foreach (Customer i in customerlist)
            {
                Console.WriteLine(i.Salary);
            }

            sortByName sortbyname = new sortByName();
            Console.WriteLine();
            Console.WriteLine("Array After sorting by name ");
            customerlist.Sort(sortbyname);

            foreach (Customer i in customerlist)
            {
                Console.WriteLine(i.Name);
            }
        }


    }

    public class Customer : IComparable<Customer>
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }

    public class sortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
