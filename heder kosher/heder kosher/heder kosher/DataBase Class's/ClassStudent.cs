using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Heder_Kosher
{
    public static class ClassStudent
    {
        public static Boolean add(string studentId, string classId)
        {
            /* The student him self or the reception guy is allow to add student to new class
             * get the student id and the id of the class and add the student to the StudentClass DB
             * 
             * conditions:
             * if the student deon's ecxist : return false
             * if the student is allready registred in more than one class : return false
             * otherwise : return true
             */

            //check if the student excist
            DataTable studentTable = Access.Select("*", "StudentDetails WHERE studentID =" + "'" + studentId + "'");
            if (studentTable.Rows.Count <= 0) return false;

            //check if classID exist
            if(!Class.CheckExistClassID(classId))return false;


            //how to Insert new row to data base
            Access.Insert("StudentClass", "'" + studentId + "','" + classId + "'");
            return true;
        }


        public static DataTable getClassByID(string studentId)
        {
            /* In case like : the student wants to see the details about his class.
             * Look the student in SC-DB
             * Return the row in witch the student excist in Class DB
             * 
             * condition :
             * if the student doesnt registred to any class reutrn null
             */
            DataTable table = Access.Select("*", "StudentClass WHERE studentID =" + "'" + studentId + "'");
            if (table.Rows.Count <= 0) return null;
            string classId = table.Rows[0]["ClassID"].ToString();

            table = Access.Select("*", "Class WHERE classID =" + "'" + classId + "'");
            if (table.Rows.Count <= 0) return null; //the classId not found
            return table;
        }

        public static Boolean remove(string studentID)
        {
            /*
             * The student him-self or the reception guy is allow to remove the student from some class
             * get the student id and remove him from the SC-DB
             *  
             */

            DataTable studentTable = Access.Select("*", "StudentDetails WHERE studentID =" + "'" + studentID + "'");
            if (studentTable.Rows.Count <= 0) return false;

            DataTable studentIdCheck = Access.Select("*", "StudentClass WHERE studentID =" + "'" + studentID + "'");
            if (studentIdCheck.Rows.Count <= 0) return false;

            Access.Delete("StudentClass", "WHERE [studentID] = " + "'" + studentID + "'" + "");
            return true;
        }
        public static DataTable getAll()
        {
            /*
             * return a new datatable with colums : studentId , classId , className
             */

            //read all from studentclass db
            DataTable classStudentTable = Access.Select("*", "StudentClass");

            //initialize new data table
            DataTable returnTable = new DataTable();

            //initialize 3 new columns for the table
            DataColumn studentId = new DataColumn("studentId", System.Type.GetType("System.String"));
            studentId.ReadOnly = false;
            studentId.Unique = true;
            DataColumn classId = new DataColumn("classId", System.Type.GetType("System.String"));
            classId.ReadOnly = false;
            classId.Unique = false;
            DataColumn className = new DataColumn("className", System.Type.GetType("System.String"));
            className.ReadOnly = false;
            className.Unique = false;

            //add the columns to the table
            returnTable.Columns.Add(studentId);
            returnTable.Columns.Add(classId);
            returnTable.Columns.Add(className);

            DataRow newRow;

            //fill the data table with the details
            for (int i = 0; i < classStudentTable.Rows.Count; i++)
            {
                newRow = returnTable.NewRow();
                newRow["studentId"] = classStudentTable.Rows[i]["studentID"].ToString();
                newRow["classId"] = classStudentTable.Rows[i]["classId"].ToString();
                DataTable classTable = Access.Select("*", "Class WHERE classId =" + "'" + classStudentTable.Rows[i]["classId"].ToString() + "'");
                newRow["className"] = classTable.Rows[0]["className"].ToString();
                returnTable.Rows.Add(newRow);
            }

            return returnTable;


        }
    }
}
