using System.Windows.Forms;

namespace MidtermLabExam
{
    partial class StudentPageIndividual
    {
        private System.ComponentModel.IContainer components = null;

        // Static Labels
        private System.Windows.Forms.Label lblStudentId, lblFullName, lblAddress, lblBirthdate, lblAge, lblContact, lblEmail, lblGuardian, lblHobbies, lblNickname, lblCourse, lblYear;

        // Dynamic Labels
        private System.Windows.Forms.Label lblStudentIdValue, lblFullNameValue, lblAddressValue, lblBirthdateValue, lblAgeValue, lblContactValue, lblEmailValue, lblGuardianValue, lblHobbiesValue, lblNicknameValue, lblCourseValue, lblYearValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Initialize Static Labels
            lblStudentId = CreateLabel("Student ID:");
            lblFullName = CreateLabel("Full Name:");
            lblAddress = CreateLabel("Address:");
            lblBirthdate = CreateLabel("Birthdate:");
            lblAge = CreateLabel("Age:");
            lblContact = CreateLabel("Contact No.:");
            lblEmail = CreateLabel("Email:");
            lblGuardian = CreateLabel("Guardian:");
            lblHobbies = CreateLabel("Hobbies:");
            lblNickname = CreateLabel("Nickname:");
            lblCourse = CreateLabel("Course:");
            lblYear = CreateLabel("Year Level:");

            // Initialize Dynamic Labels
            lblStudentIdValue = CreateLabel("");
            lblFullNameValue = CreateLabel("");
            lblAddressValue = CreateLabel("");
            lblBirthdateValue = CreateLabel("");
            lblAgeValue = CreateLabel("");
            lblContactValue = CreateLabel("");
            lblEmailValue = CreateLabel("");
            lblGuardianValue = CreateLabel("");
            lblHobbiesValue = CreateLabel("");
            lblNicknameValue = CreateLabel("");
            lblCourseValue = CreateLabel("");
            lblYearValue = CreateLabel("");

            // Set positions and add controls to form
            SetControlPositions();

            // Form Settings
            this.Text = "Student Details";
            this.Size = new System.Drawing.Size(600, 470); // Adjusted for total height of labels
            this.Load += new System.EventHandler(this.StudentPageIndividual_Load);
            this.ResumeLayout(false);
        }

        // Helper method to create labels
        private System.Windows.Forms.Label CreateLabel(string text)
        {
            return new System.Windows.Forms.Label
            {
                Text = text,
                AutoSize = true
            };
        }

        // Helper method to set control positions
        private void SetControlPositions()
        {
            int xLabel = 20, xValue = 150, y = 20, gap = 30;

            // Static and Dynamic Labels
            var labels = new (Label label, Label value)[]
            {
                (lblStudentId, lblStudentIdValue),
                (lblFullName, lblFullNameValue),
                (lblAddress, lblAddressValue),
                (lblBirthdate, lblBirthdateValue),
                (lblAge, lblAgeValue),
                (lblContact, lblContactValue),
                (lblEmail, lblEmailValue),
                (lblGuardian, lblGuardianValue),
                (lblHobbies, lblHobbiesValue),
                (lblNickname, lblNicknameValue),
                (lblCourse, lblCourseValue),
                (lblYear, lblYearValue)
            };

            foreach (var (label, valueLabel) in labels)
            {
                label.SetBounds(xLabel, y, 120, 25);
                valueLabel.SetBounds(xValue, y, 250, 25);
                y += gap;
                this.Controls.AddRange(new Control[] { label, valueLabel });
            }
        }
    }
}
