namespace WhoIs
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSeaching = new System.Windows.Forms.Button();
            this.btnPageButtons = new System.Windows.Forms.Button();
            this.btnStudNotesSect = new System.Windows.Forms.Button();
            this.btnCopyright = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Drew\'s WhoIs Program";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(681, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSeaching
            // 
            this.btnSeaching.Location = new System.Drawing.Point(4, 52);
            this.btnSeaching.Name = "btnSeaching";
            this.btnSeaching.Size = new System.Drawing.Size(125, 23);
            this.btnSeaching.TabIndex = 5;
            this.btnSeaching.Text = "Seaching";
            this.btnSeaching.UseVisualStyleBackColor = true;
            this.btnSeaching.Click += new System.EventHandler(this.btnSeaching_Click);
            // 
            // btnPageButtons
            // 
            this.btnPageButtons.Location = new System.Drawing.Point(4, 93);
            this.btnPageButtons.Name = "btnPageButtons";
            this.btnPageButtons.Size = new System.Drawing.Size(125, 23);
            this.btnPageButtons.TabIndex = 6;
            this.btnPageButtons.Text = "Search Screen Buttons";
            this.btnPageButtons.UseVisualStyleBackColor = true;
            this.btnPageButtons.Click += new System.EventHandler(this.btnPageButtons_Click);
            // 
            // btnStudNotesSect
            // 
            this.btnStudNotesSect.Location = new System.Drawing.Point(4, 134);
            this.btnStudNotesSect.Name = "btnStudNotesSect";
            this.btnStudNotesSect.Size = new System.Drawing.Size(125, 23);
            this.btnStudNotesSect.TabIndex = 7;
            this.btnStudNotesSect.Text = "Student Notes Section";
            this.btnStudNotesSect.UseVisualStyleBackColor = true;
            this.btnStudNotesSect.Click += new System.EventHandler(this.btnStudNotesSect_Click);
            // 
            // btnCopyright
            // 
            this.btnCopyright.Location = new System.Drawing.Point(4, 174);
            this.btnCopyright.Name = "btnCopyright";
            this.btnCopyright.Size = new System.Drawing.Size(125, 23);
            this.btnCopyright.TabIndex = 8;
            this.btnCopyright.Text = "Copyright Info";
            this.btnCopyright.UseVisualStyleBackColor = true;
            this.btnCopyright.Click += new System.EventHandler(this.btnCopyright_Click);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(135, 52);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(620, 361);
            this.rtbText.TabIndex = 9;
            this.rtbText.Text = "";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 457);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnCopyright);
            this.Controls.Add(this.btnStudNotesSect);
            this.Controls.Add(this.btnPageButtons);
            this.Controls.Add(this.btnSeaching);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.Text = "Help File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSeaching;
        private System.Windows.Forms.Button btnPageButtons;
        private System.Windows.Forms.Button btnStudNotesSect;
        private System.Windows.Forms.Button btnCopyright;
        private System.Windows.Forms.RichTextBox rtbText;
    }
}