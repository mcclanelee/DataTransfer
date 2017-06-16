using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTransfer.Models.Domain
{
    public class Employer
    {
        private List<Employee> employees = new List<Employee>();
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
    }
}