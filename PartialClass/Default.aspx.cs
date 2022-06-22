using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClass
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PartialClassCustomer c2 = new PartialClassCustomer();
            c2.FirstName = "Ibrahim";
            c2.LastName = "Arafeh";
            string FullName = c2.FullName();
            Response.Write("Full Name using Partial Class is : " + FullName);
        }
    }
}