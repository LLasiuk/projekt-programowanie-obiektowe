using System;


//temat1/zadanie6
namespace Finances.Employees
{
    public class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //temat1/zadanie5
        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}\nFirst name: {FirstName}\nLast name: {LastName}\nAge: {Age}");
        }

        //temat1/zadanie5
        public void ChangeInfo(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        //temat1/zadanie9
        public Person()
        {

        }

        //temat1/zadanie9
        public Person(int id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        //temat1/zadanie9
        public Person(int id)
        {
            Id = id;
        }
    }
}
