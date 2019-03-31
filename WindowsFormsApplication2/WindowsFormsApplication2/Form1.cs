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
            string query = "INSERT INTO Student (FirstName,LastName,Contact,Email,RegistrationNumber,Status) VALUES('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtContact.Text + "', '" + txtEmail.Text + "', '" + txtRegNumber.Text + "', '" + comboBox1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Inserted Successfully!");
            //txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNumber.Text = "";
            comboBox1.Text = "";
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
           // txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNumber.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE Student SET FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', Contact = '" + txtContact.Text + "', Email = '" + txtEmail.Text + "', RegistrationNumber = '" + txtRegNumber.Text + "', Status = '" + comboBox1.Text + "' WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Updated Successfully!");
            //txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNumber.Text = "";
            comboBox1.Text = "";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);*/
            //txtId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtContact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtRegNumber.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string combo = "SELECT LookupId FROM Lookup WHERE LookupId = 5 OR LookupId = 6";
                SqlDataAdapter da = new SqlDataAdapter(combo, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Lookup");
                comboBox1.DisplayMember = "LookupId";
                comboBox1.ValueMember = "LookupId";
                comboBox1.DataSource = ds.Tables["Lookup"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!");
            }
            /*SqlDataAdapter sda = new SqlDataAdapter("SELECT isnull(max(cast(Id as int)),0)+1 from Student", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtId.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txtFirstName;*/
            //disp();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "DELETE FROM Student WHERE Id=" + id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Deleted!!");
            //txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtRegNumber.Text = "";
            comboBox1.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
            int selectrowindex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectrowindex];
            string id = Convert.ToString(selectedRow.Cells["Id"].Value);
            string query = "UPDATE Clo SET Name = '" + txtClo.Text + "' WHERE Id=" +id;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Selected CLO updated successfully!");
            txtClo.Text = "";
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtClo.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            //dateTimePicker1.Value.ToShortDateString() = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            conn.Open();
            string query = "INSERT INTO Rubric (Details, CloId) VALUES ('"+richTextBox1.Text+"', '"+comboBox1.Text+"')";
            //string query1 = "INSERT INTO Rubric(Details, CloId)  SELECT Id, Name FROM Clo WHERE Id = CloId " VALUES ('" + richTextBox1.Text + "', '" + query + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Rubrics added!");
            richTextBox1.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Rubric";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
            conn.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sc = new SqlCommand("Select Id, CloId from Rubric", conn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("CloId", typeof(string));
            dt.Load(reader);
            comboBox1.DisplayMember = "CloId";
            comboBox1.ValueMember = "Id"; comboBox1.DataSource = dt;
            conn.Close();
        }
    }
}
