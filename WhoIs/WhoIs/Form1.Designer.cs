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
            this.img1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.SuspendLayout();
            // 
            // img1
            // 
            this.img1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.img1.Image = global::WhoIs.Properties.Resources.Student2;
            this.img1.InitialImage = ((System.Drawing.Image)(resources.GetObject("img1.InitialImage")));
            this.img1.Location = new System.Drawing.Point(40, 12);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(160, 233);
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            // 
            // btnWhoIs
            // 
            this.btnWhoIs.Location = new System.Drawing.Point(223, 54);
            this.btnWhoIs.Name = "btnWhoIs";
            this.btnWhoIs.Size = new System.Drawing.Size(194, 28);
            this.btnWhoIs.TabIndex = 1;
            this.btnWhoIs.Text = "Who is this?";
            this.btnWhoIs.UseVisualStyleBackColor = true;
            this.btnWhoIs.Click += new System.EventHandler(this.btnWhoIs_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(224, 28);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(193, 20);
            this.txtStudentID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a student ID or last name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(221, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "If more than one student is found please select a student from the list below to " +
    "see a picture:";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(224, 150);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(193, 95);
            this.lstStudents.TabIndex = 5;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // lnlStudentID
            // 
            this.lnlStudentID.AutoSize = true;
            this.lnlStudentID.Location = new System.Drawing.Point(40, 266);
            this.lnlStudentID.Name = "lnlStudentID";
            this.lnlStudentID.Size = new System.Drawing.Size(61, 13);
            this.lnlStudentID.TabIndex = 6;
            this.lnlStudentID.Text = "Student ID:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(40, 288);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname:";
            // 
            // lblGivenNames
            // 
            this.lblGivenNames.AutoSize = true;
            this.lblGivenNames.Location = new System.Drawing.Point(40, 311);
            this.lblGivenNames.Name = "lblGivenNames";
            this.lblGivenNames.Size = new System.Drawing.Size(80, 13);
            this.lblGivenNames.TabIndex = 8;
            this.lblGivenNames.Text = "Given Name(s):";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(40, 335);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(35, 13);
            this.lblTutor.TabIndex = 9;
            this.lblTutor.Text = "Tutor:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(40, 359);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(64, 13);
            this.lblCourse.TabIndex = 10;
            this.lblCourse.Text = "Course Info:";
            // 
            // lblIDData
            // 
            this.lblIDData.AutoSize = true;
            this.lblIDData.Location = new System.Drawing.Point(134, 266);
            this.lblIDData.Name = "lblIDData";
            this.lblIDData.Size = new System.Drawing.Size(0, 13);
            this.lblIDData.TabIndex = 11;
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Location = new System.Drawing.Point(134, 288);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(0, 13);
            this.lblSurnameInfo.TabIndex = 12;
            // 
            // lblGivenNameInfo
            // 
            this.lblGivenNameInfo.AutoSize = true;
            this.lblGivenNameInfo.Location = new System.Drawing.Point(134, 311);
            this.lblGivenNameInfo.Name = "lblGivenNameInfo";
            this.lblGivenNameInfo.Size = new System.Drawing.Size(0, 13);
            this.lblGivenNameInfo.TabIndex = 13;
            // 
            // lblTutorInfo
            // 
            this.lblTutorInfo.AutoSize = true;
            this.lblTutorInfo.Location = new System.Drawing.Point(134, 335);
            this.lblTutorInfo.Name = "lblTutorInfo";
            this.lblTutorInfo.Size = new System.Drawing.Size(0, 13);
            this.lblTutorInfo.TabIndex = 14;
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.AutoSize = true;
            this.lblCourseInfo.Location = new System.Drawing.Point(134, 359);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(0, 13);
            this.lblCourseInfo.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(342, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWhoIs
            // 
            this.AcceptButton = this.btnWhoIs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 423);
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
            this.Controls.Add(this.img1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWhoIs";
            this.Text = "Who is this?";
            this.Enter += new System.EventHandler(this.btnWhoIs_Click);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
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
    }
}

