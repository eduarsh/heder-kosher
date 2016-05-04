using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heder_Kosher
{
    public static class StudentDetails
    {
        public static Boolean Add(string id,string subscriptionDate, string medicalCheckDate){

            //check valid subscription and madicenCheck
            try
            {
                Convert.ToDateTime(subscriptionDate);
                Convert.ToDateTime(medicalCheckDate);
            }

            catch
            {
                MessageBox.Show("הכנסת תאריך לא תקין");
                return false;
            }

            try
            {
                Access.Insert("StudentDetails", "'" + id + "','" + subscriptionDate + "','" + medicalCheckDate + "','0'");
                return true;
            }

            catch{//if the student already exsits then show a message about it
                return false;
            }
        }

        public static Boolean Remove(string id)
        {
            try
            {
                Access.Delete("StudentDetails", "WHERE [studentID] = '" + id + "'");
                return true;
            }

            catch (Exception e){
                MessageBox.Show(e.ToString());
                return false;
            }

        }

        public static Boolean checkValidSubscriptonAndMedicanCheck()
        {
            //get the value from the databse

            DataTable table = Access.Select("*", "StudentDetails WHERE studentID =" + "'" + User.Instance.currentUser.ID + "'");

            if (table.Rows.Count <= 0) return false;

            string gymSubscription = table.Rows[0]["validitySubscription"].ToString();
            string medicalValidetion = table.Rows[0]["validMedicalCertificate"].ToString();

            DateTime gymDate = Convert.ToDateTime(gymSubscription);
            DateTime medDate = Convert.ToDateTime(medicalValidetion);

            if (gymDate <= DateTime.Now || medDate <= DateTime.Now) return false;
            return true;

        }

        public static int getNoOffMissedClasses(string studentId){
            //Get the no of the missed classes by studen
            DataTable table = Access.Select("*", "StudentDetails WHERE studentID =" + "'" + User.Instance.currentUser.ID + "'");
            if (table.Rows.Count <= 0) return -1;
            return int.Parse(table.Rows[0]["validRegisterToClass"].ToString());
        }
    }
}
