using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Student_Details
{
    class StudentClass
    {
        string strcon = "server=chester\\SQLEXPRESS;integrated security=true;database=MkpSample;";
        //Insert method
        public string InsertStudent(int RollNo, string Name, string Gender, string Hobby,string City, string DOB)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "insert into Student values(@rno,@name,@gender,@hobby,@city,@dob)";
                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@rno", RollNo);
                    command.Parameters.AddWithValue ("name", Name);
                    command.Parameters.AddWithValue("@gender", Gender);
                    command.Parameters.AddWithValue("@hobby", Hobby);
                    command.Parameters.AddWithValue("@city", City);
                    command.Parameters.AddWithValue("@dob", DOB);

                    command.ExecuteNonQuery();
                    con.Close();
                    return "Records saved successfully";

                }

            }
        }
        //Update student Method
        public string UpdateStudent(int RollNo,string Name, string Gender, string Hobby, String City, String DOB)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "update Student set Name=@name,Gender=@gender,Hobby=@hobby,City=@city,DOB=@dob where RollNo=@rno";
                using(SqlCommand command = new SqlCommand(str,con))
                {
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@gender", Gender);
                    command.Parameters.AddWithValue("@hobby", Hobby);
                    command.Parameters.AddWithValue("@city", City);
                    command.Parameters.AddWithValue("@dob", DOB);
                    command.Parameters.AddWithValue("@rno", RollNo);

                    command.ExecuteNonQuery();
                    con.Close();
                    return "Records Updated Successfully";


                }
            }
        }
        //Delete Student Method
        public string DeleteStudent(int RollNo,string Name)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "Delete from Student where RollNo=@rno or Name=@name";
                using( SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@rno",RollNo);
                    command.Parameters.AddWithValue("@name", Name);

                    command.ExecuteNonQuery();
                    con.Close();
                    return "Records Deleted Successfully";

                }
            }
        }
        //Search Student Method
        public List<StudentSearch>SearchStudent(int RollNo)
        {
            using(SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string str = "Select * from Student where RollNo=@rno";
                using (SqlCommand command = new SqlCommand(str,con))
                {
                    command.Parameters.AddWithValue("@rno", RollNo);
                    SqlDataReader dr = command.ExecuteReader();
                    List<StudentSearch> li = new List<StudentSearch>();
                    while (dr.Read())
                    {
                        li.Add(new StudentSearch(Convert.ToInt32(dr["RollNo"].ToString()), dr["Name"].ToString(), dr["Gender"].ToString(), dr["Hobby"].ToString(), dr["City"].ToString(), dr["DOB"].ToString()));
                    }
                    return li;
                }
            }
        }

    }
}
