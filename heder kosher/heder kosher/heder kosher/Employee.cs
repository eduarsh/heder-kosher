using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heder_Kosher
{
    public class Employee : GymUser
    {
        public override bool AddNewGymUser(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string rank){
            if(Users.Add(id, firstName, lastName, pass, gender, phone, mail, rank))return true;
            return false;
        }

        public override bool RemoveGymUser(string id){
            if(Users.Remove(id))return true;
            return false;

        }

        public override Boolean AddNewStudent(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string subscriptionDate, string medicalCheckDate)
        {
            if (!Users.Add(id, firstName, lastName, pass, gender, phone, mail, "Student")) return false;
            if (!StudentDetails.Add(id, subscriptionDate, medicalCheckDate)){
                Users.Remove(id);
                return false;
            } 
            return true;
        }

        public override Boolean RemoveStudent(string id){
            if (!Users.Remove(id)) return false;
            if (!StudentDetails.Remove(id)) return false;
            return true;
        }


    }
}
