using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WhoIs
{
    class DBConnector
    {
        //THANK YOU FOR YOUR TIME DBCONNECTOR. I APPRECIATE ALL YOUR EFFORTS BUT WE HAVE DECIDED TO GO IN A DIFFERENT DIRECTION.

        //static string connectionString = @"user id=browno; password=BorderCollie; server=\\138.79.113.5; Trusted_Connection=yes; database=SmartNZCH; connection timeout=30";

        //public static List<Student> StudentListBySurname(string inputEntry)
        //{
        //    List<Student> students = new List<Student>();

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        string idValue = inputEntry.Substring(inputEntry.Length - 4);
        //        conn.Open();
        //        string sql = @"SELECT InstituteID, StudentNumber, Surname, GivenNames, Birthdate FROM Person WHERE Surname LIKE %"
        //                        + inputEntry + "% OR GivenNames LIKE %" + inputEntry + "% OR PersonID = " + idValue;
        //        using (SqlCommand command = new SqlCommand(sql, conn))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Student student = new Student();
                            
        //                    student.studentNumber = reader.GetInt32(1);
        //                    student.surname = reader.GetString(2);
        //                    student.givenNames = reader.GetString(3);
                           
        //                    students.Add(student);
        //                }
        //            }

        //        }
        //    }
        //    return students;
        //}
    }
}
