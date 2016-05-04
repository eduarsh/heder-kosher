using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Heder_Kosher
{
    public static class WorkArrangement
    {
        private static bool checkIfExist(string id)
        {
            /*
             * function checks if ID is exist in WorkArrangement table
             * */

            DataTable check;
            check = Access.Select("*", "WorkArrangement WHERE studentID =" + "'" + id + "'");
            if (check.Rows.Count == 0)
                return false;
            else
                return true;
        }


        public static bool update(string id, string day, string hour)
        {
            /* updating data base
             * 
             * */
            if (checkIfExist(id))
            {
                Access.Update("WorkArrangement", "[employeeID]= '" + id + "', [day]= '" + day + "', [hour]='" + hour + "'" + " WHERE [employeeID]= '" + id + "'");
                return true;
            }
            else
                return false;


        }

        public static bool remove(string id, string day, string hour)
        {

            if (Users.CheckExistUserByID(id))
            {
                Access.Delete("WorkArrangement", "WHERE [employeeID] = '" + id + "'");
                return true;
            }
            else
                return false;

        }


        public static bool add(string id, string day, string hour)
        {
            if (!Users.CheckExistUserByID(id))
            {
                Access.Insert("WorkArrangement", "'" + id + "','" + day + "','" + hour + "'");

                return true;
            }
            return false;
        }


        public static void Clear()
        {
            DataTable x = Access.Select("*", "WorkArrangement");
            for (int i = 0; i < x.Rows.Count; i++)
            {
                string id = x.Rows[i]["employeeID"].ToString();
                Access.Delete("WorkArrangement", "WHERE [employeeID] = " + id + "'");
            }

        }

        public static DataTable GetDataTable(string day, string hour){

            DataTable oldData = new DataTable();
            DataTable data = new DataTable();
            data.Clear();
            data.Columns.Add("firstName");//adding first name to the new data table
            data.Columns.Add("lastName");//adding last name to the new data table
            data.Columns.Add("rank"); ;//adding rank to the new data table
            oldData = Access.Select("employeeID", "WorkArrangement WHERE day=" + "'" + day + "','hour=" + hour);//getting all the id's that work this day and hour

            foreach (DataRow row in oldData.Rows)
            {
                DataRow newRow = data.NewRow();//creating new row 
                newRow["firstName"] = row["firstName"];//copying first name from old database
                newRow["lastName"] = row["lastName"];//copying last name from old database
                newRow["rank"] = row["rank"];//copying rank name from old database
            }
            return data;
        }



    }
}


