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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            this.ActiveControl = btnExit;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeaching_Click(object sender, EventArgs e)
        {
            rtbText.Text = "In the search box you can enter:\r\n     \u2022  A student ID\r\n     \u2022  Part or all of a student’s first name\r\n     \u2022  Part"
                + " or all of a student’s last name\r\n     \u2022  NB: You cannot enter a student’s entire name\r\n\r\nIf more than one student is found via a Student"
                + " ID search, that will be a student who has more than one contract. In this instance the students name will be listed once for each contract in the"
                + " Student List box and the photo will be displayed. You will need to click on one of the names listed to display further details such as name and"
                + " assigned tutor.\r\n\r\nIf searching for a student via first or last name (or part thereof) all matching students will be listed in the Student"
                + " List box and you will have to select one of these to display their picture and details. You can click on each of the students listed to change"
                + " the selected student as required.\r\n\r\nLeaving the Search box empty will produce a list of all current students in the Student List box. Note"
                + ", this can take a few seconds to appear.\r\n\r\nYou can initiate a search by either using the mouse to click on the “Who is this?” button or "
                + "pushing the Enter key.";
        }

        private void btnPageButtons_Click(object sender, EventArgs e)
        {
            rtbText.Text = "\"Copy ID\" button – will copy the currently displayed student’s ID to the clipboard for pasting into another location.\r\n\r\n" 
                + "\"Copy Image\" button – will copy the currently displayed student’s picture to the clipboard for pasting into another location.\r\n\r\n"
                + "\"Help\" button – displays this page.\r\n\r\n\"Notes\" button – will enlarge the WhoIs window and display the student notes section (See"
                + " student Notes section below). When clicked this will become the “Close Notes” button which will resize the window back to the original "
                + "size, closing the “Student Notes:” section.\r\n\r\n\"Exit\" button – closes the program.\r\n\r\n\"Go to Student's APlus+ Page\" button will" 
                + " take you to the students page in APlus+. However, note that you need to be logged in to APlus+ for this to work. If you are not logged in, you will"
                + " be presented with the APlus+ login page. Once logged in, you can continue within APlus+ or click the \"Go to Student's APlus+ Page\" button again"
                + " to go to the students page";
        }

        private void btnStudNotesSect_Click(object sender, EventArgs e)
        {
            rtbText.Text = "The student notes when opened will displayed the currently stored notes for the displayed student. Note that these are not encrypted"
                + " and are freely accessible to anyone with network access to G: drive – so mind your language! These notes are not editable through this "
                + "window.\r\n\r\nA note will automatically add the current date and the name of the currently logged in staff member. Note that you can manually"
                + " change the name in the Staff Member box when necessary.\r\n\r\nEnter your note and click the “Add Comment” button to confirm the note, add it"
                + " to the students notes and close the “Enter a Student Note” window. The new note will be immediately visible in the Student Notes section after"
                + " the “Enter a Student Note” window closes. Note that once entered, a note cannot be changed by the user. If required, email drew.white@cpp.ac.nz"
                + " with the student’s details and the necessary change clearly stated for a manual alteration to be made.\r\n\r\nClick the “Cancel” button to exit"
                + " the “Enter a Student Note” window without adding a note.";
        }

        private void btnCopyright_Click(object sender, EventArgs e)
        {
            rtbText.Text = "This program is free for any CPP staff to use where appropriate but not for you to mess with. If anybody does, I will add logons to it " +
                " AND YOU WON'T GET ONE!\r\n\r\nRemember that notes are available to anyone with G: drive access, so mind your language!" 
                + "\r\n\r\n\u00A9DrewWhite2018";
        }
    }
}
