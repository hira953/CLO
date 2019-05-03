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
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO StudentAttendance (AttendanceId,StudentId,AttendanceStatus) VALUES ('" + comboBox1.Text + "', '" + comboBox2.Text + "', (select LookupId from Lookup where Name='" + comboBox3.Text + "'))";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Inserted Successfully!");
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE StudentAttendance SET AttendanceId = '" + comboBox1.Text + "', StudentId = '" + comboBox2.Text + "', AttendanceStatus = (select LookupId from Lookup where Name='" + comboBox3.Text + "') WHERE AttendanceId =" +id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data updated successfully!");
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "DELETE FROM StudentAttendance WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!");
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM StudentAttendance";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            comboBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            comboBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
        }

        private void UserControl8_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.projectBDataSet6.Student);
            this.lookupTableAdapter.Fill(this.projectBDataSet15.Lookup);
            this.classAttendanceTableAdapter.Fill(this.projectBDataSet16.ClassAttendance);
        }
    }
}
