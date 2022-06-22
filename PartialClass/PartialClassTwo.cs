using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClass
{
    public partial class PartialClassCustomer
    {
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}