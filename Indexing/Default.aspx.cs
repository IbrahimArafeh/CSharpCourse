using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indexing
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            string EmployeeName = "Name of Employee is " + company[1];
            pHeader.InnerText = EmployeeName;
        }
    }
}