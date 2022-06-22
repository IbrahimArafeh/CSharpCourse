using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEqualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.FirstName = "ibrahim";
            c1.LastName = "arafeh";

            customer c2 = new customer();
            c2.FirstName = "ibrahim";
            c2.LastName = "arafeh";

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));


        }

        public class customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                if (!(obj is customer))
                {
                    return false;
                }

                return this.FirstName == ((customer)obj).FirstName &&
                    this.LastName == ((customer)obj).LastName;
            }

            public override int GetHashCode()
            {
                return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
            }
        }
    }
}
