using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances.Employees
{
    public class Employees
    {
        //temat3/zadanie1
        public List<Employee> ListOfEmployees = new List<Employee>();

        //temat4/zadanie1
        private string[] _tableOfFirstLastName = new string[100];

        public string this[int i]
        { 
            get { return _tableOfFirstLastName[i]; }
            set { _tableOfFirstLastName[i] = value; }
        }

        //temat5/zadanie2
        public void AddEmployee()
        {
            ListOfEmployees.Add(EmployeeFactory.CreateEmployee());
        }

        //temat5/zadanie3
        public void AddEmployeeDemo() 
        {
            var id = ListOfEmployees.Count + 1;
            Console.Write("Enter first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            foreach (var employee in ListOfEmployees)
            {
                if(employee.FirstName == firstName && employee.LastName == lastName)
                    Console.WriteLine("User already exists.");
                return;
            }

            ListOfEmployees.Add(EmployeeFactory.CreateEmployee(id, firstName, lastName, age));
        }

        //temat5/zadanie3
        public void RemoveEmployee() 
        {
            ShowEmployees();
            Console.Write("Enter ID to delete employee: ");
            var id = Convert.ToInt32(Console.ReadLine());
            //where to jest Linq
            ListOfEmployees.Remove(ListOfEmployees.Where(employee => employee.EmployeeId == id).First()); 
        }

        //temat5/zadanie3
        public void ShowEmployees()
        {
            Console.WriteLine("List of employees:");
            foreach (var employee in ListOfEmployees)
            {
                Console.WriteLine($"ID: {employee.EmployeeId}   Name: {employee.FirstName}  Last name: {employee.LastName}  Age: {employee.Age}");
            }
        }

        //temat5/zadanie3
        public Employee GetEmployee()
        {
            ShowEmployees();
            Console.Write("Enter employee id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            return ListOfEmployees.First(x => x.EmployeeId == id);
        }

    }
}
