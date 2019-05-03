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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime dc = DateTime.Now;
            string query = "INSERT INTO Assessment(Title, DateCreated, TotalMarks, TotalWeightage) VALUES ('" + textBox1.Text + "', '" + dc + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data added!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView4.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView4.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE Assessment SET Title = '" + textBox1.Text + "', TotalMarks = '" + textBox2.Text + "', TotalWeightage = '" + textBox3.Text + "' WHERE Id = " + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data updated successfully!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView4.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView4.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "DELETE FROM Assessment WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Assessment";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView4[1, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView4[3, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView4[4, e.RowIndex].Value.ToString();
        }
    }
}
