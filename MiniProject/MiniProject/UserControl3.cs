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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            int Id = 0;
            string query1 = "SELECT count(*) FROM Rubric";
            SqlDataReader Reader;
            SqlCommand cmd = new SqlCommand(query1, conn);
            Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                Id = Convert.ToInt32(Reader[0]) + 1;
            }
            conn.Close();
            conn.Open();
            string query = "INSERT INTO Rubric (Id,Details, CloId) VALUES ('" + Id + "','" + richTextBox1.Text + "', '" + comboBox2.Text + "')";
            //string query1 = "INSERT INTO Rubric(Details, CloId)  SELECT Id, Name FROM Clo WHERE Id = CloId " VALUES ('" + richTextBox1.Text + "', '" + query + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Rubrics added!");
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView3.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView3.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE Rubric SET CloId = '" + comboBox2.Text + "', Details = '" + richTextBox1.Text + "' WHERE Id = " + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data updated successfully!");
            comboBox2.Text = "";
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView3.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView3.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "DELETE FROM Rubric WHERE Id = " + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!");
            comboBox2.Text = "";
            richTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Rubric";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
            conn.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = dataGridView3[1, e.RowIndex].Value.ToString();
            comboBox2.Text = dataGridView3[2, e.RowIndex].Value.ToString();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            this.cloTableAdapter2.Fill(this.projectBDataSet5.Clo);
        }

        private void cloBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
