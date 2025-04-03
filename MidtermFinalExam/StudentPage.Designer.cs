using System.Windows.Forms;

namespace MidtermLabExam
{
    partial class StudentPage
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewStudents;
        private Button btnView;

        private void InitializeComponent()
        {
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            // Reduced size of DataGridView
            this.dataGridViewStudents.Size = new System.Drawing.Size(350, 200);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(12, 220);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // StudentPage
            // 
            // Adjusted form size to fit smaller DataGridView and button
            this.ClientSize = new System.Drawing.Size(375, 260);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "StudentPage";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.StudentPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
