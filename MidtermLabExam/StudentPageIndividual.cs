using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MidtermLabExam
{
    public partial class StudentPageIndividual : Form
    {
        private int studentId;

        public StudentPageIndividual(int studentId)
        {
            InitializeComponent();  // No parameters needed
            this.studentId = studentId;
        }

        private void StudentPageIndividual_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=StudentInfoDB;";
            string query = @"
                SELECT s.*, c.courseName, y.yearLvl
                FROM StudentRecordTB s
                LEFT JOIN CourseTB c ON s.courseId = c.courseId
                LEFT JOIN YearTB y ON s.yearId = y.yearId
                WHERE s.studentId = @studentId";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@studentId", studentId);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        lblStudentIdValue.Text = reader["studentId"].ToString();
                        lblFullNameValue.Text = $"{reader["firstName"]} {reader["middleName"]} {reader["lastName"]}";
                        lblAddressValue.Text = $"{reader["houseNo"]}, {reader["brgyName"]}, {reader["municipality"]}, {reader["province"]}, {reader["region"]}, {reader["country"]}";
                        lblBirthdateValue.Text = reader["birthdate"].ToString();
                        lblAgeValue.Text = reader["age"].ToString();
                        lblContactValue.Text = reader["studContactNo"].ToString();
                        lblEmailValue.Text = reader["emailAddress"].ToString();
                        lblGuardianValue.Text = $"{reader["guardianFirstName"]} {reader["guardianLastName"]}";
                        lblHobbiesValue.Text = reader["hobbies"].ToString();
                        lblNicknameValue.Text = reader["nickname"].ToString();
                        lblCourseValue.Text = reader["courseName"].ToString(); // Display course name
                        lblYearValue.Text = reader["yearLvl"].ToString(); // Display year level
                    }
                    else
                    {
                        MessageBox.Show("No student details found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student details: " + ex.Message);
            }
        }
    }
}