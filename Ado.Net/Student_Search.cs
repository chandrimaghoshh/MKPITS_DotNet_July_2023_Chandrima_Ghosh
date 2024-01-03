using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Details
{
    class StudentSearch
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Hobby { get; set; }
        public string City { get; set; }
        public string DOB { get; set; }

        public StudentSearch(int Rollno, string Name, string Gender, string Hobby, string City, string DOB)
        {
            this.RollNo = Rollno;
            this.Name = Name;
            this.Gender = Gender;
            this.Hobby = Hobby;
            this.City = City;
            this.DOB = DOB;
        }

    }
}

