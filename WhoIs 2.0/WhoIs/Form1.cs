using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WhoIs
{
    public partial class frmWhoIs : Form
    {
        //Network path to student photos folder
        String BASEPATH = @"G:\Education\Trainees\Photos\";
        //Path for location of the data csv.
        String STUDENTCSV = @"G:\Education\Trainees\CurrentStudents\Instructor and Student Detail.csv";
        String STUDENTNOTES = @"G:\Education\Trainees\CurrentStudents\Notes\";
        String STUDENTRESULTSREPORT = @"G:\Education\Trainees\CurrentStudents\Student Course Results Summary.csv";
        List<Student> students;
        
        public frmWhoIs()
        {
            InitializeComponent();
            txtStudentID.Select();
            this.Width = 490;
            this.Height = 465;
            //img1.Visible = true;
        }

        private void btnWhoIs_Click(object sender, EventArgs e)
        {
            try
            {
                StudentImporter studentList = new StudentImporter(STUDENTCSV);//Imports the csv file contents
                List<Student> multiStudentResults = new List<Student>(); //For storing search results
                students = studentList.import(); //adds the list of students to the local variable
                ClearLabels();
                hideNotesPanel();
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
                        lblIDData.Text = txtStudentID.Text;
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
            txtNotes.Text = "";
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

        //Sets the image box to default image
        private void setDefaultImage()
        {
            img1.Image = img1.InitialImage;
            img1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        //Adds the image for the current student to image box
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

        //Button event to display or hide notes for current student
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            if (btnNotes.Text == "Notes")
            {
                showNotesPanel();
            }
            else if (btnNotes.Text == "Close Notes")
            {
                hideNotesPanel();
            }
        }

        //Show the notes panel making objects in it visible
        private void showNotesPanel()
        {
            this.Width = 1050;
            txtNotes.Visible = true;
            lblNotes.Visible = true;
            btnNotes.Text = "Close Notes";
            GetNotes();
        }

        //Hide the notes panel making objects in it not visible
        private void hideNotesPanel()
        {
            this.Width = 490;
            txtNotes.Visible = false;
            lblNotes.Visible = false;
            btnNotes.Text = "Notes";
        }

        //Builds the file name and path for student notes and adds contents to the notes text box
        private void GetNotes()
        {
            string file = STUDENTNOTES + lblIDData.Text + ".txt";
            Boolean isNotes = File.Exists(file);
            if (isNotes)
            {
                txtNotes.Text = File.ReadAllText(file);
            }
            else
            {
                txtNotes.Text = "No notes for this student";
            }
        }

        public void InputDialog()
        {            
            String studentID = lblIDData.Text;
            Form prompt = new frmEnterNote(studentID, STUDENTNOTES);
            prompt.ShowDialog();
            GetNotes();
            
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            InputDialog();
            
        }

        private void btnCopyImage_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(img1.Image);
        }

        private void btnCopyID_Click(object sender, EventArgs e)
        {
            if (lblIDData.Text == "")
                Clipboard.SetText("There was no ID to copy! Go back and try again.");
            else
                Clipboard.SetText(lblIDData.Text);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp HelpForm = new frmHelp();
            HelpForm.Visible = true;
        }
        //Functionality to open the students page in APlus+ 
        private void btnGoToAPlusPlus_Click(object sender, EventArgs e)
        {
            String studentID = lblIDData.Text;

            try
            {
                string fileData = null;
                string APlusID = "";
                string Path = @"https://vpn.whitireia.ac.nz/,DanaInfo=apluspte+?module=students&page=student&studentID=";

                using (StreamReader reader = File.OpenText(STUDENTRESULTSREPORT))
                {
                    fileData = reader.ReadToEnd();
                }

                string[] lines = fileData.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n'); //Just in case there is some mac weilding weirdo in the house
                
                foreach (string line in lines)
                {
                    string[] columns = line.Split(',');
                    string firstColumn = columns[0].Replace("\"", string.Empty);                    

                    if (firstColumn == studentID)
                    {
                        APlusID = columns[1];
                        break;
                    }
                }

                if (APlusID == "")
                {
                    MessageBox.Show("Unable to find an APlus+ ID for the current student\r\n" + Path, "Cannot go to student APlus+ page", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    Path = Path + APlusID;
                    Process.Start(Path);
                }

            } catch
            {
                MessageBox.Show("I am sorry but an error has occurred in the processing of your request.");
            }
        }
    }
}
