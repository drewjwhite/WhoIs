namespace WhoIs
{
    partial class frmWhoIs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWhoIs));
            this.btnWhoIs = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lnlStudentID = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGivenNames = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblIDData = new System.Windows.Forms.Label();
            this.lblSurnameInfo = new System.Windows.Forms.Label();
            this.lblGivenNameInfo = new System.Windows.Forms.Label();
            this.lblTutorInfo = new System.Windows.Forms.Label();
            this.lblCourseInfo = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnCopyImage = new System.Windows.Forms.Button();
            this.btnCopyID = new System.Windows.Forms.Button();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnGoToAPlusPlus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.whoIsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAttendancePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWhoIs
            // 
            this.btnWhoIs.Location = new System.Drawing.Point(220, 110);
            this.btnWhoIs.Name = "btnWhoIs";
            this.btnWhoIs.Size = new System.Drawing.Size(194, 28);
            this.btnWhoIs.TabIndex = 1;
            this.btnWhoIs.Text = "Who is this?";
            this.btnWhoIs.UseVisualStyleBackColor = true;
            this.btnWhoIs.Click += new System.EventHandler(this.btnWhoIs_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(221, 84);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(193, 20);
            this.txtStudentID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a student ID or last name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(218, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "If more than one student is found please select a student from the list below to " +
    "see a picture:";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(220, 187);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(193, 95);
            this.lstStudents.TabIndex = 5;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // lnlStudentID
            // 
            this.lnlStudentID.AutoSize = true;
            this.lnlStudentID.Location = new System.Drawing.Point(37, 322);
            this.lnlStudentID.Name = "lnlStudentID";
            this.lnlStudentID.Size = new System.Drawing.Size(61, 13);
            this.lnlStudentID.TabIndex = 6;
            this.lnlStudentID.Text = "Student ID:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(37, 344);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname:";
            // 
            // lblGivenNames
            // 
            this.lblGivenNames.AutoSize = true;
            this.lblGivenNames.Location = new System.Drawing.Point(37, 367);
            this.lblGivenNames.Name = "lblGivenNames";
            this.lblGivenNames.Size = new System.Drawing.Size(80, 13);
            this.lblGivenNames.TabIndex = 8;
            this.lblGivenNames.Text = "Given Name(s):";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(37, 391);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(35, 13);
            this.lblTutor.TabIndex = 9;
            this.lblTutor.Text = "Tutor:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(37, 415);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(64, 13);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.Text = "Course Info:";
            // 
            // lblIDData
            // 
            this.lblIDData.AutoSize = true;
            this.lblIDData.Location = new System.Drawing.Point(131, 322);
            this.lblIDData.Name = "lblIDData";
            this.lblIDData.Size = new System.Drawing.Size(0, 13);
            this.lblIDData.TabIndex = 11;
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Location = new System.Drawing.Point(131, 344);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(0, 13);
            this.lblSurnameInfo.TabIndex = 12;
            // 
            // lblGivenNameInfo
            // 
            this.lblGivenNameInfo.AutoSize = true;
            this.lblGivenNameInfo.Location = new System.Drawing.Point(131, 367);
            this.lblGivenNameInfo.Name = "lblGivenNameInfo";
            this.lblGivenNameInfo.Size = new System.Drawing.Size(0, 13);
            this.lblGivenNameInfo.TabIndex = 13;
            // 
            // lblTutorInfo
            // 
            this.lblTutorInfo.AutoSize = true;
            this.lblTutorInfo.Location = new System.Drawing.Point(131, 391);
            this.lblTutorInfo.Name = "lblTutorInfo";
            this.lblTutorInfo.Size = new System.Drawing.Size(0, 13);
            this.lblTutorInfo.TabIndex = 14;
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.AutoSize = true;
            this.lblCourseInfo.Location = new System.Drawing.Point(131, 415);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(0, 13);
            this.lblCourseInfo.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(455, 68);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(78, 13);
            this.lblNotes.TabIndex = 17;
            this.lblNotes.Text = "Student Notes:";
            this.lblNotes.Visible = false;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.SystemColors.Info;
            this.txtNotes.Location = new System.Drawing.Point(458, 97);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(560, 370);
            this.txtNotes.TabIndex = 18;
            this.txtNotes.Visible = false;
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(258, 444);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(75, 23);
            this.btnNotes.TabIndex = 19;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.BtnNotes_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(905, 68);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(113, 23);
            this.btnAddNote.TabIndex = 20;
            this.btnAddNote.Text = "Add a note:";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnCopyImage
            // 
            this.btnCopyImage.Location = new System.Drawing.Point(177, 444);
            this.btnCopyImage.Name = "btnCopyImage";
            this.btnCopyImage.Size = new System.Drawing.Size(75, 23);
            this.btnCopyImage.TabIndex = 21;
            this.btnCopyImage.Text = "Copy Image";
            this.btnCopyImage.UseVisualStyleBackColor = true;
            this.btnCopyImage.Click += new System.EventHandler(this.btnCopyImage_Click);
            // 
            // btnCopyID
            // 
            this.btnCopyID.Location = new System.Drawing.Point(96, 444);
            this.btnCopyID.Name = "btnCopyID";
            this.btnCopyID.Size = new System.Drawing.Size(75, 23);
            this.btnCopyID.TabIndex = 22;
            this.btnCopyID.Text = "Copy ID";
            this.btnCopyID.UseVisualStyleBackColor = true;
            this.btnCopyID.Click += new System.EventHandler(this.btnCopyID_Click);
            // 
            // img1
            // 
            this.img1.Image = global::WhoIs.Properties.Resources.Student2;
            this.img1.InitialImage = ((System.Drawing.Image)(resources.GetObject("img1.InitialImage")));
            this.img1.Location = new System.Drawing.Point(32, 68);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(163, 251);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(15, 444);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 23;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnGoToAPlusPlus
            // 
            this.btnGoToAPlusPlus.Location = new System.Drawing.Point(220, 296);
            this.btnGoToAPlusPlus.Name = "btnGoToAPlusPlus";
            this.btnGoToAPlusPlus.Size = new System.Drawing.Size(193, 23);
            this.btnGoToAPlusPlus.TabIndex = 24;
            this.btnGoToAPlusPlus.Text = "Go to Student\'s APlus+ Page";
            this.btnGoToAPlusPlus.UseVisualStyleBackColor = true;
            this.btnGoToAPlusPlus.Click += new System.EventHandler(this.btnGoToAPlusPlus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whoIsToolStripMenuItem,
            this.attendanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // whoIsToolStripMenuItem
            // 
            this.whoIsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToHomepageToolStripMenuItem});
            this.whoIsToolStripMenuItem.Name = "whoIsToolStripMenuItem";
            this.whoIsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.whoIsToolStripMenuItem.Text = "WhoIs";
            // 
            // goToHomepageToolStripMenuItem
            // 
            this.goToHomepageToolStripMenuItem.Name = "goToHomepageToolStripMenuItem";
            this.goToHomepageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.goToHomepageToolStripMenuItem.Text = "Go To Homepage";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAttendancePageToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // openAttendancePageToolStripMenuItem
            // 
            this.openAttendancePageToolStripMenuItem.Name = "openAttendancePageToolStripMenuItem";
            this.openAttendancePageToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openAttendancePageToolStripMenuItem.Text = "Open Attendance Page";
            // 
            // frmWhoIs
            // 
            this.AcceptButton = this.btnWhoIs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 504);
            this.Controls.Add(this.btnGoToAPlusPlus);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCopyID);
            this.Controls.Add(this.btnCopyImage);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCourseInfo);
            this.Controls.Add(this.lblTutorInfo);
            this.Controls.Add(this.lblGivenNameInfo);
            this.Controls.Add(this.lblSurnameInfo);
            this.Controls.Add(this.lblIDData);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.lblGivenNames);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lnlStudentID);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnWhoIs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmWhoIs";
            this.Text = "Who is this?";
            this.Enter += new System.EventHandler(this.btnWhoIs_Click);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Button btnWhoIs;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lnlStudentID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGivenNames;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblIDData;
        private System.Windows.Forms.Label lblSurnameInfo;
        private System.Windows.Forms.Label lblGivenNameInfo;
        private System.Windows.Forms.Label lblTutorInfo;
        private System.Windows.Forms.Label lblCourseInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnCopyImage;
        private System.Windows.Forms.Button btnCopyID;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnGoToAPlusPlus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem whoIsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAttendancePageToolStripMenuItem;
    }
}

