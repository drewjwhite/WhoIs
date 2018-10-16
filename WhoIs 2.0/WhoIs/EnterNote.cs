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

namespace WhoIs
{
    public partial class frmEnterNote : Form
    {        
        String studentID;
        string path;

        public frmEnterNote(String studentID, String path)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.path = path;
            setup();
        }

        public void setup()
        {
            txtDate.Text = DateTime.Now.Date.ToShortDateString();
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String[] getName = userName.Split('\\');
            txtStaffMember.Text = getName[1];
            this.ActiveControl = txtComment;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String comment = txtDate.Text + "\t\t" + txtStaffMember.Text + "\r\n" + txtComment.Text;
            String filePath = path + studentID + ".txt";
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, "\r\n\r\n" + comment);
            }
            else
            {
                File.WriteAllText(filePath, comment);
            }
            
            this.Close();
                       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
