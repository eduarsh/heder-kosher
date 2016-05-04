using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heder_Kosher
{
    public class Student : GymUser
    {

        private static int Tcount = 0;  //remmber the index training row

        public static Boolean checkValidConection(){

            if(StudentDetails.checkValidSubscriptonAndMedicanCheck())return true;
            return false;
        }

        public override Boolean registerToClass(string studentId, string classId){
            if (StudentDetails.getNoOffMissedClasses(studentId) > 2)
                return false; //too much missed classes

            //check if the student allready registred to the class
            DataTable studentIdCheck = Access.Select("*", "StudentClass WHERE studentID =" + "'" + studentId + "'");
            if (studentIdCheck.Rows.Count > 0) return false;
            //nothing found - continue

            if(base.registerToClass(studentId, classId))return true;
            return false;
        }

        public DataRow ShowTrainingProgram()//the student asks to show his training program
        {
            if (TrainingProgram.checkExsistingTrainingProgram(this.ID)){
                DataTable table = TrainingProgram.GetStudentById(this.ID);
                if (table.Rows.Count > Tcount && Tcount >= 0)
                    return table.Rows[Tcount];
                else{
                    Tcount = 0;
                    return table.Rows[Tcount];
                }
            }
            return null;
        }

        public void ResetTcount(){
            Tcount = 0;
        }

        public void NextTrainingProgram(){
            Tcount++;
        }

        public void PreTrainingProgram()
        {
            Tcount--;
        }

        public override bool AddNewGymUser(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string rank) { return false; }

        public override bool RemoveGymUser(string id) { return false; }

        public override Boolean AddNewStudent(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string subscriptionDate, string medicalCheckDate) { return false; }

        public override Boolean RemoveStudent(string id) { return false; }
    }
}
