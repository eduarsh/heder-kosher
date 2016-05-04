using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public class Instructor : Employee
    {
        public override bool AddNewGymUser(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string rank) { return false; }

        public override bool RemoveGymUser(string id) { return false; }

        public override Boolean AddNewStudent(string id, string firstName, string lastName, string pass, string gender, string phone, string mail, string subscriptionDate, string medicalCheckDate) { return false; }

        public override Boolean RemoveStudent(string id) { return false; }
    }
}
