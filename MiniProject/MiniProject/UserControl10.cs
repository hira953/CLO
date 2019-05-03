using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MiniProject
{
    public partial class UserControl10 : UserControl
    {
        public UserControl10()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            comboBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            comboBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) VALUES ('" + comboBox1.Text + "', '" + comboBox2.Text + "', '" + comboBox3.Text + "', '" + dateTimePicker1.Value.Date + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Inserted Successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["StudentId"].Value);
            string query = "UPDATE StudentResult SET StudentId = '" + comboBox1.Text + "', AssessmentComponentId = '" + comboBox2.Text + "', RubricMeasurementId = '" + comboBox3.Text + "', EvaluationDate = '" + dateTimePicker1.Value.Date + "' WHERE StudentId=" +id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["StudentId"].Value);
            string query = "DELETE FROM StudentResult WHERE StudentId=" +id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data updated successfully!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM StudentResult";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void UserControl10_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.projectBDataSet7.Student);
            this.assessmentComponentTableAdapter.Fill(this.projectBDataSet8.AssessmentComponent);
            this.rubricLevelTableAdapter.Fill(this.projectBDataSet9.RubricLevel);
        }
    }
}
