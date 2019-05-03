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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO ClassAttendance(AttendanceDate) VALUES ('"+dateTimePicker1.Value.Date+"')";
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
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE ClassAttendance SET AttendanceDate = '" + dateTimePicker1.Value.Date + "' WHERE Id=" +id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "DELETE FROM ClassAttendance WHERE Id=" +id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!!");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM ClassAttendance";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dateTimePicker1.Value.Date = dataGridView1[1, e.RowIndex].Value.ToString(); 
        }
    }
}
