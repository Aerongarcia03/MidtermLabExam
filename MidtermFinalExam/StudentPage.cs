using MidtermLabExam;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MidtermLabExam
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
            // Reset Button Design to Default
            ResetButtonDesign();
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=StudentInfoDB;";
            string query = "SELECT studentId, CONCAT(firstName, ' ', lastName) AS fullName FROM StudentRecordTB";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewStudents.DataSource = dataTable;

                    // Disable adding new rows to prevent the extra blank row
                    dataGridViewStudents.AllowUserToAddRows = false;

                    // Remove any blank rows programmatically if needed
                    for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
                    {
                        if (string.IsNullOrWhiteSpace(dataTable.Rows[i]["fullName"].ToString()))
                        {
                            dataTable.Rows.RemoveAt(i);
                        }
                    }

                    // Check if no students were found
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No students found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                try
                {
                    int studentId = Convert.ToInt32(dataGridViewStudents.CurrentRow.Cells[0].Value);
                    StudentPageIndividual individualPage = new StudentPageIndividual(studentId);
                    individualPage.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student record.");
            }
        }

        // Method to reset the button design to default
        private void ResetButtonDesign()
        {
            btnView.BackColor = System.Drawing.SystemColors.Control; // Default background color
            btnView.ForeColor = System.Drawing.SystemColors.ControlText; // Default text color
            btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular); // Default font
            btnView.Size = new System.Drawing.Size(75, 23); // Default size
            btnView.FlatStyle = FlatStyle.Standard; // Default style (Standard button)
            btnView.FlatAppearance.BorderSize = 1; // Default border size
            btnView.Cursor = Cursors.Default; // Default cursor style
        }
    }
}
