using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heder_Kosher
{
    public class Manager : Employee
    {



        public bool AddEmployee(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string rank, int salary){
            if(!base.AddNewGymUser(id, firstName, lastName, pass, gender, phone, mail, rank))return false;
            if (!Employees.Add(id, salary)) return false;
            return true;
        }

        public void RemoveEmployee(string id){
            if (!(id == ""))
                if (Employees.Remove(id) && base.RemoveGymUser(id)) MessageBox.Show("מחיקה בוצע בהצלחה");
                else MessageBox.Show("מחיקה נכשלה בדוק האם תעודת זהות זו קיימת");
            else
                MessageBox.Show("שדה תעודת זהות ריק");
        }

        public bool AddClass(string InstructorID, string className, string dayMeeting, string timeMeeting){
            if(CheckClassDitails( InstructorID,  className,  dayMeeting,  timeMeeting))
                if (Class.add(Help.RandomNumber(4).ToString(), InstructorID, className, dayMeeting, timeMeeting))
                    return true;
            return false;
        }
        public bool RemoveClass(string classID){
            if (!Class.remove(classID)){
                return false;
            }
            return true;
        }

        public DataTable GetAllClasses(){
            return Class.getAll();
        }

        public bool updateWorkSheet(string id, string day, string hour){
            if (WorkArrangement.update(id, day, hour))
                return true;
            return false;
        }

        public bool addWorkSheet(string id, string day, string hour){

            if (WorkArrangement.add(id, day, hour))
                return true;
            return false;
        }
        public bool removeWorkSheet(string id, string day, string hour){

            if (WorkArrangement.remove(id, day, hour))
                return true;
            return false;
        }
        public void clearWorkHour(){
            WorkArrangement.Clear();
        }

        private bool CheckClassDitails(string InstructorID, string className, string dayMeeting, string timeMeeting){
            TimeSpan Time;
            TimeSpan Open;
            TimeSpan Close;


             if (!(Access.Select("*", "Users WHERE userID = '" + InstructorID + "'").Rows[0]["rank"].ToString() == "Instructor")){
                 MessageBox.Show("תעודת זהות של מדריך לא קיים");
                return false;
             }

            try
            {
                TimeSpan.Parse(timeMeeting);
            }

            catch
            {
                MessageBox.Show("שעה הוכנסה בפורמט לא נכון נסה שנית");
                return false;
            }


            Time = TimeSpan.Parse(timeMeeting);
            Open = TimeSpan.Parse("7:0:0");
            Close = TimeSpan.Parse("23:0:0");

            if (dayMeeting != "Friday" && (TimeSpan.Compare(Time, Open) < 0 || TimeSpan.Compare(Time, Close) > 0))
            {
                MessageBox.Show("שעה ויום לא תאומים לתנאי הפתיחה של המקום");
                return false;
            }

            Close = TimeSpan.Parse("14:0:0");
            if (dayMeeting == "Friday" && (TimeSpan.Compare(Time, Open) < 0 || TimeSpan.Compare(Time, Close) > 0))
            {
                MessageBox.Show("שעה ויום לא תאומים לתנאי הפתיחה של המקום");
                return false;
            }

            return true;

        }
    }
}
