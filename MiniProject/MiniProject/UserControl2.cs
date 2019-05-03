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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void btnaddclo_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime dc = DateTime.Now;
            string query = "INSERT INTO Clo(Name, DateCreated, DateUpdated) VALUES ('" + txtClo.Text + "', '" + dc + "', '" + dc + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("CLO's added!");
            txtClo.Text = "";
        }

        private void btnupdClo_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE Clo SET Name = '" + txtClo.Text + "' WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Selected CLO updated successfully!");
            txtClo.Text = "";
        }

        private void btndelClo_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "DELETE FROM Clo WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!");
            txtClo.Text = "";
        }

        private void btnviewClo_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Clo";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
            txtClo.Text = "";
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtClo.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
