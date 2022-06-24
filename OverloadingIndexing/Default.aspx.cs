using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OverloadingIndexing
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            pText.InnerText = "The Count of Male Employee before set function: " + company["Male"] + "\r\n" +
                "The Count of Male Employee after set function : " + company["Male"];
        }
    }
}