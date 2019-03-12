using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Student (FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtContact.Text + "', '" + txtEmail.Text + "', '" + txtRegNumber.Text + "', '" + txtStatus.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Inserted Successfully!");
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNumber.Text = "";
            txtStatus.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Student";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNumber.Text = "";
            txtStatus.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Student SET FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', Contact = '" + txtContact.Text + "', Email = '" + txtEmail.Text + "', RegistrationNumber = '" + txtRegNumber.Text + "', Status = '" + txtStatus.Text + "' WHERE Id = '"+txtId.Text+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Updated Successfully!");
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNumber.Text = "";
            txtStatus.Text = "";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtContact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtRegNumber.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtStatus.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT isnull(max(cast(Id as int)),0)+1 from Student", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtId.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txtFirstName;
            //disp();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "DELETE FROM Student where Id = '"+txtId.Text+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!!");
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNumber.Text = "";
            txtStatus.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Clo(Name, DateCreated, DateUpdated) VALUES ('" + txtClo.Text + "', '" + dateTimePicker1.Value.ToShortDateString() + "', '" + dateTimePicker2.Value.ToShortDateString() + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("CLO's added!");
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

        private void btnupdClo_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "UPDATE Clo SET Name = '" + txtClo.Text + "', DateCreated = '" + dateTimePicker1.Value.ToShortDateString() + "', DateUpdated = '" + dateTimePicker2.Value.ToShortDateString() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Selected CLO updated successfully!");
            txtClo.Text = "";
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtClo.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            //dateTimePicker1.Value.ToShortDateString() = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
