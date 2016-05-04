using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public static class Users
    {

        public static bool CheckExistUserByID(string id){
            //return true if the id is found
            if (Access.Select("*", "Users WHERE UserID = '" + id + "'").Rows.Count > 0)
                return true;
            return false;
        }

        public static bool Add(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string rank){
            //check id
            if (CheckExistUserByID(id)) return false;

            //if the id not exict add new person
            Access.Insert("Users", "'" + id + "','" + firstName + "','" + lastName + "','" + pass + "','" + gender + "','" + phone + "','" + mail + "','" + rank + "'");

            return true;
        }

        public static bool Remove(string id){
            //check id
            if (CheckExistUserByID(id)) return false;

            //delete user
            Access.Delete("Users", "WHERE [userID] = '" + id + "'");

            return true;
        }
    }
}
