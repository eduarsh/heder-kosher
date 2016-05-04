using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Heder_Kosher
{
    public sealed class User
    {
        private static Student stud = null;
        private static Trainer train = null;
        private static Instructor instruct = null;
        private static ReceptionEmployee secra = null;
        private static Manager mana = null;
        private static DataTable data;
        private static User user = null;

        private User() { }

        public GymUser currentUser
        {
            get { return CurrentUser(); }
        }

        public Student student
        {
            get{
                if(stud == null)
                    return stud = new Student();
                return stud;
            }
        }

        public Trainer trainer
        {
            get {
                if (stud == null)
                    return train = new Trainer();
                return trainer;
            }
        }

        public Instructor instructor
        {
            get {
                if (stud == null)
                    return instruct = new Instructor();
                return instruct;
            }
        }

        public ReceptionEmployee secratry
        {
            get {
                if (stud == null)
                    return secra = new ReceptionEmployee();
                return secra;
            }
        }

        public Manager manager{
            get {
                if (stud == null)
                    return mana = new Manager();
                return mana;
            }
        }

        public static User Instance{
            get { return instance(); }
        }


        public  bool LoadUser(string id ,string pass){
            if (!CheckLoginDetails(id, pass))
             {
                 MessageBox.Show("שם משתמש או סיסמה לא תקינים נסה שנית.");
                 return false;
             }
            data = Access.Select("*", "Users WHERE userID = '" + id + "'");
            FactoryMethod(data);

            return true;
        }

        private static User instance(){
            if (user == null)
                return user = new User();
            else
                return user;
        }

        public void FactoryMethod(DataTable data)
        {
            switch (data.Rows[0]["Rank"].ToString()){
                case "Student":
                    stud = new Student();
                    stud.FillFields(data);
                    break;

                case "Trainer":
                    train = new Trainer();
                    train.FillFields(data);
                    break;

                case "Instructor":
                    instruct = new Instructor();
                    instruct.FillFields(data);
                    break;

                case "Secretary":
                    secra = new ReceptionEmployee();
                    secra.FillFields(data);
                    break;

                case "Manager":
                    mana = new Manager();
                    mana.FillFields(data);
                    break;

                default:
                    break;
            }
        }

        private static GymUser CurrentUser()
        {
            switch (data.Rows[0]["Rank"].ToString()){
                case "Student":
                    if (stud == null)
                        return stud = new Student();
                    return stud;

                case "Trainer":
                    if (train == null)
                        return train = new Trainer();
                    return train;

                case "Instructor":
                    if (instruct == null)
                        return instruct = new Instructor();
                    return instruct;

                case "Secretary":
                    if (secra == null)
                        return secra = new ReceptionEmployee();
                    return secra;

                case "Manager":
                    if (mana == null)
                        return mana = new Manager();
                    return mana;

                default:
                    return null;
            }
        }

        private bool CheckLoginDetails(string id, string pass){
            DataTable data = Access.Select("*", "Users WHERE userID = '" + id  +"'");

            if (data.Rows.Count <= 0)
                return false;

            if (data.Rows[0]["pass"].ToString() != pass.ToString())
                return false;

            return true;
        }

        
        
    }
}
