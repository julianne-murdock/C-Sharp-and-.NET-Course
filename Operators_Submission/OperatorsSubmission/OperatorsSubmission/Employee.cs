using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Employee : Person //overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. Remember that comparison operators must be overloaded in pairs.
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return true;
            else
                return employee.ID == employee2.ID;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.ID != employee2.ID;
        }

        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.ID.Equals(emp.ID);
        }
    }
}
