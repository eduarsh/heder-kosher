using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heder_Kosher
{
    public abstract class Person
    {
        private string id;
        private string firstName;
        private string lastName;
        private string pass;
        private string gender;
        private string phone;
        private string mail;
        private string rank;

        public Person(){
            //constructor
            this.id = "";
            this.firstName = "";
            this.lastName = "";
            this.pass = "";
            this.gender = "";
            this.phone = "";
            this.mail = "";
            this.rank = "";
        }

        public void FillFields(DataTable data){
            this.id = data.Rows[0][0].ToString();
            this.firstName = data.Rows[0][1].ToString();
            this.lastName = data.Rows[0][2].ToString();
            this.pass = data.Rows[0][3].ToString();
            this.gender = data.Rows[0][4].ToString();
            this.phone = data.Rows[0][5].ToString();
            this.mail = data.Rows[0][6].ToString();
            this.rank = data.Rows[0][7].ToString();
        }


        public string ID{
            get{return id;}

            set{this.id = value;}
        }

        public string FirstName
        {
            get { return firstName; }

            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }

            set { this.lastName = value; }
        }

        public string Password
        {
            get { return pass; }

            set { this.pass = value; }
        }


        public string Gender
        {
            get { return gender; }

            set { this.gender = value; }
        }

        public string Phone
        {
            get { return phone; }

            set { this.phone = value; }
        }

        public string Mail
        {
            get { return mail; }

            set { this.mail = value; }
        }

        public string Rank
        {
            get { return rank; }

            set { this.rank = value; }
        }

    }
}
