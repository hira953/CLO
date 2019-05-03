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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void button13_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime dc = DateTime.Now;
            string query = "INSERT INTO AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) VALUES ('" + textBox4.Text + "', '" + comboBox4.Text + "', '" + textBox7.Text + "', '" + dc + "', '" + dc + "', '" + comboBox5.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data added!");
            textBox4.Text = "";
            textBox7.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView6[1, e.RowIndex].Value.ToString();
            comboBox4.Text = dataGridView6[2, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView6[3, e.RowIndex].Value.ToString();
            comboBox5.Text = dataGridView6[6, e.RowIndex].Value.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView6.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView6.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE AssessmentComponent SET Name = '" + textBox4.Text + "', RubricId = '" + comboBox4.Text + "', TotalMarks = '" + textBox7.Text + "', AssessmentId = '" + comboBox5.Text + "' WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data updated successfully!");
            textBox4.Text = "";
            textBox7.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView6.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView6.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "DELETE FROM AssessmentComponent WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!");
            textBox4.Text = "";
            textBox7.Text = "";
            comboBox5.Text = "";
            comboBox4.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM AssessmentComponent";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView6.DataSource = dt;
            conn.Close();
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {
            this.rubricTableAdapter.Fill(this.projectBDataSet2.Rubric);
            this.assessmentTableAdapter.Fill(this.projectBDataSet3.Assessment);
        }
    }
}
