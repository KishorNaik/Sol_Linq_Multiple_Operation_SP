using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Linq_Multiple_Operation_SP
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAL EmpDAL = new EmployeeDAL();

            #region Insert Operation


            EmpDAL.InsertEmployee(new EmployeeEntity() {FirstName = "Kishor", LastName = "Naik", DOB = DateTime.Now});

            #endregion

            #region Select Operation

            List<ORD.SpEmployeeResult> ListEmployee = EmpDAL.GetEmployeeData().ToList();

            #endregion
        }
    }
}
