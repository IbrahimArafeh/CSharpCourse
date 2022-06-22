using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClass
{
    public class Customer
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}