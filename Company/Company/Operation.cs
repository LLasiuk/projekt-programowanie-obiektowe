using System;


//temat1/zadanie6
namespace Finances.Employees
{
   public class Operation
    {

        public int IdPayroll { get; set; }
        public DateTime DatePayroll { get; set; }
        public string NameOfPayroll { get; set; }

        //temat1/zadanie9
        public Operation(int idPayroll, DateTime datePayroll, string nameOfPayroll)
        {
            IdPayroll = idPayroll;
            DatePayroll = datePayroll;
            NameOfPayroll = nameOfPayroll;
        }

    }
}
