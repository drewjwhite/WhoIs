using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoIs
{
    public partial class frmWhoIs : Form
    {
        //Network path to student photos folder
        String BASEPATH = @"G:\Education\Trainees\Photos\";
        //Path for location of the data csv.
        String STUDENTCSV = @"G:\Education\Trainees\CurrentStudents\Instructor and Student Detail.csv";
        List<Student> students;
        
        public frmWhoIs()
        {
            InitializeComponent();
            txtStudentID.Select();
        }

        private void btnWhoIs_Click(object sender, EventArgs e)
        {
            try
            {
                StudentImporter studentList = new StudentImporter(STUDENTCSV);//Imports the csv file contents
                List<Student> multiStudentResults = new List<Student>(); //For storing search results
                students = studentList.import(); //adds the list of students to the local variable
                ClearLabels();
                foreach (Student student in students)
                {
                    if (student.studentNumber.Contains(txtStudentID.Text)) //Checks the search entry against the student list data
                    {
                        ClearLabels();
                        SetData(student);
                        multiStudentResults.Add(student); //populates the search results list
                    }
                    else if (student.surname.ToLower().Contains(txtStudentID.Text.ToLower()) || student.givenNames.ToLower().Contains(txtStudentID.Text.ToLower()))
                    {                        
                        multiStudentResults.Add(student); //populates the search results list
                    }
                }
                if (multiStudentResults.Count == 0)
                {
                    if (Int32.TryParse(txtStudentID.Text, out int result))
                    {
                        //Takes the student number and builds the image path string
                        lstStudents.Items.Clear();
                        addImage();
                        ClearLabels();
                    }
                    else
                    {
                        //Clears everything is nothing found
                        ClearLabels();
                        setDefaultImage();
                        txtStudentID.Text = "";
                        lblIDData.Text = "No student found.";
                        txtStudentID.Focus();
                    }
                }
                else if (multiStudentResults.Count == 1)
                {
                    //Actions if only one student result found
                    Student student = multiStudentResults.ElementAt(0);
                    ClearLabels();
                    SetData(student);
                }
                else if (multiStudentResults.Count > 1)
                {
                    //Actions is search results find more than one student
                    lstStudents.Items.Clear();
                    setDefaultImage();
                    foreach (Student student in multiStudentResults)
                    {
                        lstStudents.Items.Add(student);
                    }
                    if (Int32.TryParse(txtStudentID.Text, out int result))
                    {
                        //Takes the student number and builds the image path string             
                        addImage();
                    }
                } 
            }
            catch
            {
                //Just covers an error event
                //MessageBox.Show(this, "What have you been told about looking for something that is not there? Do it again, but this time do it right!", 
                //    "Student number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Text = "";
                lblIDData.Text = "No student found.";
                img1.Image = img1.InitialImage;
                img1.SizeMode = PictureBoxSizeMode.Zoom;
                txtStudentID.Focus();
            }
        }

        //Method so set the data labels and picture
        public void SetData(Student student)
        {
            string ID = BASEPATH + student.studentNumber + ".jpg";
            img1.Image = Image.FromFile(ID);
            img1.SizeMode = PictureBoxSizeMode.Zoom;
            lblIDData.Text = student.studentNumber;
            lblSurnameInfo.Text = student.surname;
            lblGivenNameInfo.Text = student.givenNames;
            lblTutorInfo.Text = student.tutor;
            lblCourseInfo.Text = student.courseInfo;
        }

        //Method to clear the decks for action or clear all labels and boxes
        public void ClearLabels()
        {
            lblIDData.Text = "";
            lblSurnameInfo.Text = "";
            lblGivenNameInfo.Text = "";
            lblTutorInfo.Text = "";
            lblCourseInfo.Text = "";
            lstStudents.Items.Clear();
        }

        //Allows user to select a student from list to display when multiple results found
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = (Student)lstStudents.SelectedItem;
            SetData(student);
            if (Int32.TryParse(txtStudentID.Text, out int result))
            {
                //Takes the student number and builds the image path string             
                addImage();               
            }
        }

        private void setDefaultImage()
        {
            img1.Image = img1.InitialImage;
            img1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void addImage()
        {
            string ID = BASEPATH + txtStudentID.Text + ".jpg";
            img1.Image = Image.FromFile(ID);
            img1.SizeMode = PictureBoxSizeMode.Zoom;           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
