using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public static class Employees
    {
        public static bool Add(string id, int salary){
            if (!Users.CheckExistUserByID(id))
                return false;
            Access.Insert("Employees", "'" + id + "','" + salary + "'");
            return true;
        }

        public static bool Remove(string id){
            if (Users.CheckExistUserByID(id))
                return false;
            Access.Delete("Employees", "WHERE [employeeID] = '" + id + "'");
            return true;
        }
    }
}
