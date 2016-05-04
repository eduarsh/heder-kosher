using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public static class Class
    {
        public static bool add(string classID, string InstructorID, string className, string dayMeeting, string timeMeeting)
        {
            if (Access.Select("*", "Class WHERE classID = '" + classID + "'").Rows.Count > 0)//if class already exists don't add
                return false;

            Access.Insert("Class", "'" + classID + "','" + InstructorID + "','" + className + "','" + dayMeeting + "','" + timeMeeting + "'");//add class
            return true;
        }
        public static bool remove(string classID)
        {
            if (!(Access.Select("*", "Class WHERE classID = '" + classID + "'").Rows.Count > 0))
            {//if class doesn't exists don't remove
                System.Windows.Forms.MessageBox.Show("מספר חוג לא נמצא");
                return false;
            }
            Access.Delete("Class", "WHERE [classID] = '" + classID + "'");//remove class
            return true;
        }
        public static DataTable getAll()
        {
            return Access.Select("*", "Class");
        }

        public static bool CheckExistClassID(string classID){
            if (Access.Select("*", "Class WHERE classID = '" + classID + "'").Rows.Count > 0)
                return true;
            return false;

        }

    }
}
