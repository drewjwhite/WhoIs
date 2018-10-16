using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WhoIs
{
    class StudentImporter
    {
        private string filename;

        public StudentImporter(string fileName) {
            this.filename = fileName;
        }
        //Import all data from the csv file. Csv file is created manually by the user.
        //Tutor and Student Data report from Artena. Must be saved into the program folder shown below
        //String STUDENTCSV = @"C:\Users\ta\Documents\Visual Studio 2017\Projects\Instructor and Student Detail.csv";
        public List<Student> import()
        {
            try
            {
                string fileData = null;
                List<Student> students = new List<Student>();

                using (StreamReader reader = File.OpenText(filename))
                {
                    fileData = reader.ReadToEnd();
                }

                string[] lines = fileData.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n'); //Just in case there is some mac weilding weirdo in the house
                string firstline = lines[0];
                string[] columns = firstline.Split(',');
                if (columns[0].Contains("moecampustext"))
                {
                    lines[0] = ""; //Clears the headings in the csv file
                }

                foreach (string line in lines)
                {
                    //line.Replace("\"", "");
                    if (String.IsNullOrEmpty(line))
                        continue; //To skip over blank lines i.e. the first line

                    string[] columnData = line.Split(','); //Splits each line into a new array
                    Student student = new Student();
                    student.tutor = columnData[2].Trim().Replace("\"", "");
                    student.studentNumber = columnData[3];
                    student.givenNames = columnData[4];
                    student.surname = columnData[5];
                    student.courseInfo = columnData[6];
                    students.Add(student);
                }
                return students;
            }
            catch
            {
                MessageBox.Show("It would appear that the csv file with student information is not present. Please copy " +
                    "the file into XXX directory and try again.", "We had an oopsie!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }            
        }

    }
}
