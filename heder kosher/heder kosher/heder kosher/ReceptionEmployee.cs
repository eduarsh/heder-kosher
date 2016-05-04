using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public class ReceptionEmployee : Employee{
        public DataTable ShowAllStudentFromClass(){
            return ClassStudent.getAll();
        }
        
    }
}
