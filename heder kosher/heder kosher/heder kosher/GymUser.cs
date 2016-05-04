using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heder_Kosher
{
    public abstract class GymUser : Person{

        public DataTable ShowAllClass(){
            return Class.getAll();
        }

        public Boolean removeStudentFromClass(string studentId){
            //only for student and reception
            if (!ClassStudent.remove(studentId))
                return false; //the student cant be removed
            return true;
        }

        public DataTable GetTrainingProgram()
        {//the student asks to show his training program
            if (TrainingProgram.checkExsistingTrainingProgram(User.Instance.currentUser.ID))
            {
                if (TrainingProgram.GetStudentById(User.Instance.currentUser.ID).Rows.Count > 0)
                    return TrainingProgram.GetStudentById(User.Instance.currentUser.ID);
                else MessageBox.Show("לא נמצאו תוכניות אימונים");
            }

            return null;
        }

        public virtual Boolean registerToClass(string studentId, string classId){

            //check if the student allready registred to the class
            DataTable studentIdCheck = Access.Select("*", "StudentClass WHERE studentID =" + "'" + studentId + "'");
            if (studentIdCheck.Rows.Count > 0) return false;
            //nothing found - continue

            //only for student and reception
            if (!ClassStudent.add(studentId, classId))
                return false; //the studend hasent been added
            return true;
        }

        public abstract bool AddNewGymUser(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string rank);

        public abstract bool RemoveGymUser(string id);

        public abstract Boolean AddNewStudent(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string subscriptionDate, string medicalCheckDate);

        public abstract Boolean RemoveStudent(string id);

    }
}
