using System;
using System.Collections.Generic;

//temat1/zadanie6
namespace Finances.Employees
{
   public class Employee : Person
    {
        
        public int EmployeeId { get; set; }  
        public string JobTitle { get; set; }
        public int Salary { get; set; }
        public int AccountNumber { get; set; }

        //temat1/zadanie2
        public static int HolidayBonus = 1000;
        //temat1/zadanie3
        private Wage _wage;
        //temat1/zadanie2
        public List<Operation> _listOfOperations = new List<Operation>();
        //temat1/zadanie4
        private Contract _contract { get; set; }


        //temat1/zadanie3
        public struct Wage 
        {
            public int Basic { get; set; }
            public int Bonus { get; set; }
            public int Other { get; set; }
        }

        //temat1/zadanie4
        public enum Contract 
        {
            Fulltime,
            PartTime,
            Contract
        }

        //temat1/zadanie9
        public Employee()
        {

        }

        //temat1/zadanie9
        public Employee(int id, string firstName, string lastName, int age, int employeeId, string jobTitle, int salary) : base(id, firstName, lastName, age) 
        {
            EmployeeId = employeeId;
            JobTitle = jobTitle;
            Salary = salary;
        }

        //temat1/zadanie9
        public Employee(int id, string firstName, string lastName, int age) : base(id, firstName, lastName, age)
        {
            _listOfOperations = new List<Operation>();
            _wage = new Wage();
        }

        //temat1/zadanie5
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Id: {EmployeeId}\nJob title: {JobTitle}\nSalary: {Salary}\n");
        }

        //temat1/zadanie5
        public void ChangeEmployeeInfo(string jobTitle, int salary)
        {
           JobTitle = jobTitle;
            Salary = salary;
        }

        //temat1/zadanie5
        public void ChangeHolidayBonus(int holidayBonus)
        {
            HolidayBonus = holidayBonus;
        }

        //temat1/zadanie5
        public Wage GetWage()
        {
            //temat2/zadanie1
            Console.Write("Enter username: ");
            var givenLogin = Console.ReadLine();
            Console.Write("Enter password: ");
            var givenPass = Console.ReadLine();
            if (givenLogin == "u3ername" && givenPass == "passw0rd")
            {
                return _wage;
            }
            Console.WriteLine("Wrong credentials");
            return new Wage();
        }

        //temat1/zadanie5
        public void SetWage(int basicWage, int bonusWage, int otherWage)
        {
            //temat2/zadanie1
            Console.Write("Enter username: ");
            var givenLogin = Console.ReadLine();
            Console.Write("Enter password: ");
            var givenPass = Console.ReadLine();
            if (givenLogin == "u3ername" && givenPass == "passw0rd")
            {
                _wage.Basic = basicWage;
                _wage.Bonus = bonusWage;
                _wage.Other = otherWage;
            }
            else
            {
                Console.WriteLine("Wrong credentials");
            }
        }

        //temat1/zadanie5
        public void Payroll(int id, string nameOfPayroll)
        {
            _listOfOperations.Add(new Operation(id, DateTime.Now, nameOfPayroll));
            Console.WriteLine(nameOfPayroll);
        }

        //temat7/zadanie1
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if ((employee1.FirstName == employee2.FirstName) && (employee1.LastName == employee2.LastName))
                return true;
            else
                return false;
        }
        //temat7/zadanie1
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if ((employee1.FirstName != employee2.FirstName) && (employee1.LastName != employee2.LastName))
                return true;
            else
                return false;
        }

        //temat7/zadanie2
        public static bool operator <(Employee employee1, Employee employee2)
        {
            bool status = employee1.Salary < employee2.Salary;
            return status;
        }

        //temat7/zadanie2
        public static bool operator >(Employee employee1, Employee employee2)
        {
            bool status = employee1.Salary > employee2.Salary;
            return status;
        }

        //temat7/zadanie3
        public static implicit operator double(Employee employee)
        {
            return (double)employee.Salary;
        }

        //temat7/zadanie4
        public static int operator +(Employee employee, int number)
        {
            return employee.Salary + number;
        }

        //temat8/zadanie1,2
        public void ChangeEmployeeName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _changeSomething("Name has been changed.");
        }
        //temat8/zadanie1,2
        public delegate void ChangeSomething(string message);
        //temat8/zadanie1,2
        private ChangeSomething _changeSomething;
        //temat8/zadanie1,2
        public void AddCallback(ChangeSomething msg)
        {
            _changeSomething += msg;
        }

        //temat9/zadanie1
        public delegate void SalaryHasChanged();

        public event SalaryHasChanged ChangeSalary;

        protected virtual void OnSalaryChange()
        {
            if (ChangeSalary != null)
                ChangeSalary();
            else
                Console.WriteLine($"New Salary: {Salary}");
        }

        public void SalaryChange(int newSalary)
        {
            Console.WriteLine($"Old Salary; {Salary}");
            Salary = newSalary;
            OnSalaryChange();
        }
    }
}
