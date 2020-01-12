using Finances.Employees;
using System;

namespace ManageEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            //temat8/zadanie1,2,3
            var employee = EmployeeFactory.CreateEmployee(1, "RandomName", "RandomLastName", 18);
            Console.WriteLine($"Before changes: {employee.FirstName} {employee.LastName}");
            Action<string, string> changeName = employee.ChangeEmployeeName;
            employee.AddCallback(CallbackInfo);
            changeName("DelegateName", "DelegateLastName");
            Console.WriteLine($"After changes:  {employee.FirstName} {employee.LastName}");
            Console.ReadKey();
            Console.ReadKey();

            //temat9/zadanie1
            var employee2 = new Employee
            {
                Id = 2,
                FirstName = "EventSalaryTest",
                Salary = 5000
            };

            employee2.SalaryChange(7000);
            Console.ReadLine();
        }
        //temat8/zadanie1,2
        static void CallbackInfo(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Callback has been used.");
        }

    }

}

