using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances.Employees
{
    //temat5/zadanie1
    public class EmployeeFactory
    {
        public static Employee CreateEmployee()
        {
            return new Employee();
        }

        public static Employee CreateEmployee(int id, string firstName, string lastName, int age)
        {
            return new Employee(id, firstName, lastName, age);
        }
    }
}
