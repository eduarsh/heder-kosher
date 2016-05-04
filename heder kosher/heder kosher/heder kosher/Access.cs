using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public static class Access
    {
        public static void Sort(string tableName, string field)
        {
            Query("SELECT * FROM " + tableName + " ORDER BY " + field);
        }


        public static DataTable Select(string field , string tableName)
        {
            //u have to take care about the office virson. >2007 use database.mdb <=2007 use database.accdb

            OleDbConnection conn;
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Directory.GetCurrentDirectory() + "\\database.accdb";
            conn = new OleDbConnection(strConn);
            DataTable data;
            data = new DataTable();

            try
            {
                conn.Open();
                OleDbCommand dataAdapter = new OleDbCommand("SELECT " + field + " FROM " + tableName, conn);
                OleDbDataAdapter excelDataAdapter = new OleDbDataAdapter();
                excelDataAdapter.SelectCommand = dataAdapter;
                excelDataAdapter.Fill(data);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                conn.Close();
            }

            return data;
        }

        private static void Query(string query)
        {
            OleDbConnection conn;
            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Directory.GetCurrentDirectory() + "\\database.accdb";
            conn = new OleDbConnection(strConn);

            try
            {
                conn.Open();

                OleDbCommand dataAdapter = new OleDbCommand(query, conn);
                dataAdapter.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        public static void Insert(string fields, string values)
        {
            Query("INSERT INTO " + fields + " VALUES(" + values + ")");
        }

        public static void Update(string db, string values)
        {
            Query("Update " + db + " Set " + values + "");
        }

        public static void Delete(string db, string values)
        {
            Query("Delete * From " + db + " " + values + "");
        }
    }
}
