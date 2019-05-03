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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void button9_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) VALUES ('" + comboBox3.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data added!");
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView5.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView5.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE RubricLevel SET RubricId = '" + comboBox3.Text + "', Details = '" + textBox5.Text + "', MeasurementLevel = '" + textBox6.Text + "' WHERE Id = " + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data updated successfully!");
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView5.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView5.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "DELETE FROM RubricLevel WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!");
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM RubricLevel";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView5.DataSource = dt;
            conn.Close();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*conn.Open();
            string query = "SELECT * FROM RubricLevel";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView5.DataSource = dt;
            conn.Close();*/
            comboBox3.Text = dataGridView5[1, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView5[2, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView5[3, e.RowIndex].Value.ToString();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            this.rubricTableAdapter.Fill(this.projectBDataSet1.Rubric);
        }
    }
}
