using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indexing
{
    public class Company
    {
        List<Employee> employeeList = new List<Employee>();
        public Company()
        {
            employeeList = new List<Employee>() {
            new Employee{ID=1,Name="Ibrahim",Address="Dubai-UAE",DOB= new DateTime(1994,01,01) },
            new Employee{ID=2,Name="Amer",Address="Dubai-UAE",DOB= new DateTime(1993,05,10) },
            new Employee{ID=3,Name="omar",Address="sharjah-UAE",DOB= new DateTime(1997,10,10) },
            new Employee{ID=4,Name="Feras",Address="Damasucs-Syria",DOB= new DateTime(1999,05,01) }
            };
        }
        public string this[int empId]
        {
            get
            {
                return employeeList.FirstOrDefault(emp => emp.ID == empId).Name.ToString();
            }
            set
            {
                employeeList.FirstOrDefault(emp => emp.ID == empId).Name = value;
            }
        }
    }
}