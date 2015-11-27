using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Linq_Multiple_Operation_SP
{
    public class EmployeeDAL
    {
        public Boolean InsertEmployee(EmployeeEntity EmployeeObj)
        {
            Boolean Flag = false;
            try
            {
                ORD.EmployeeDBDataContext DC = new ORD.EmployeeDBDataContext();

                DC.SpEmployee(EmployeeObj.FirstName, EmployeeObj.LastName, EmployeeObj.DOB, "Insert");

                Flag = true;

            }
            catch (Exception ex)
            {
                throw;
            }

            return Flag;
        }

        public IEnumerable<ORD.SpEmployeeResult> GetEmployeeData()
        {
            ORD.EmployeeDBDataContext DC = new ORD.EmployeeDBDataContext();

            return DC.SpEmployee(null, null, null, "Select").AsEnumerable<ORD.SpEmployeeResult>();
        }
    }
}
