using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OverloadingIndexing
{
    public class Company
    {
        List<Employee> employeesList = new List<Employee>();

        public Company()
        {
            employeesList = new List<Employee>()
            {
                new Employee(){ Id =1,Name="Ibrahim",Address="Dubai-UAE",DOB=new DateTime(1994,01,01),Gender="Male" },
                new Employee(){Id =2,Name="Aya",Address="Damascus-Syria",DOB=new DateTime(1998,01,01),Gender="Female"},
                new Employee(){Id =3,Name="Amer",Address="Sharjah-UAE",DOB=new DateTime(1993,05,01),Gender="Male"},
                new Employee(){Id =4,Name="Houda",Address="AbuDhabi",DOB=new DateTime(1994,01,01),Gender="Female"}
            };
        }

        public string this[string Male]
        {
            get
            {
                return employeesList.Count(emp => emp.Gender == Male).ToString();
            }
            set
            {
                foreach(var item in employeesList)
                {
                    item.Gender = Male;
                }
            }
        }
    }
}