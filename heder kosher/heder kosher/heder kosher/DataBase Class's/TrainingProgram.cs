using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public static class TrainingProgram
    {
        public static Boolean Add(string studentId, string trainerId, string trainingProgram)
        {//adds a training program to a student 
            if (Users.CheckExistUserByID(studentId))
            {//check if student exsists in the user database if not return false if it is then continue
                if (!checkExsistingTrainingProgram(studentId))//check if there is no program already if there isnt the do this
                {
                    Access.Insert("TrainingProgram", "'" + studentId + "','" + trainerId + "','" + trainingProgram + "'");
                    return true;
                }
            }
            return false; ;
        }

        public static Boolean Remove(string studentId)
        {//removes a training program of the student
            if (checkExsistingTrainingProgram(studentId))//checks to see if there is a program
            {
                Access.Delete("TrainingProgram", "WHERE [studentID] = '" + studentId + "'");
                return true;
            }
            return false;
        }

        public static Boolean Update(string studentId, string trainerId, string trainingProgram)
        {//gets the details of the new progra ,delete's the old one add the new one
            if (checkExsistingTrainingProgram(studentId))//check's that there is a program for that student
            {
                Remove(studentId);// removes the program
                Add(studentId, trainerId, trainingProgram);//adds the new one
                return true;
            }
            return false;
        }

        public static DataTable GetStudentById(string studentId)
        {//returns a datatable of the students program
            if (checkExsistingTrainingProgram(studentId))
                return Access.Select("*", "TrainingProgram WHERE studentID = '" + studentId + "'");
            return null;
        }
        public static DataTable GetTrainerById(string trainerId)
        {//returns all the datatables of the trainer that he trains
            if (Access.Select("*", "TrainingProgram WHERE [trainerID] = '" + trainerId + "'").Rows.Count != 0)
                return Access.Select("*", "TrainingProgram WHERE [trainerID] = '" + trainerId + "'");
            return null;
        }
        public static Boolean checkExsistingTrainingProgram(string studentId)
        {// a function that returns true if there is a training program for a student if not false
            if ((Access.Select("*", "TrainingProgram WHERE [studentID] ='" + studentId + "'")).Rows.Count != 0) return true;
            return false;
        }
    }
}
