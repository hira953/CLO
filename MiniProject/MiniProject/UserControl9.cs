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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace MiniProject
{
    public partial class UserControl9 : UserControl
    {
        public UserControl9()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("Assessment.pdf", FileMode.Create));
            doc.Open();


            PdfPTable table = new PdfPTable(dataGridView2.Columns.Count);
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView2.Columns[j].HeaderText));

            }
            table.HeaderRows = 1;
            for (int k = 0; k < dataGridView2.Rows.Count; k++)
            {
                for (int w = 0; w < dataGridView2.Columns.Count; w++)
                {
                    if (dataGridView2[w, k].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView2[w, k].Value.ToString()));

                    }

                }
            }
            doc.Add(table);
            doc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("CLO.pdf", FileMode.Create));
            doc.Open();


            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;
            for (int k = 0; k < dataGridView1.Rows.Count; k++)
            {
                for (int w = 0; w < dataGridView1.Columns.Count; w++)
                {
                    if (dataGridView1[w, k].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[w, k].Value.ToString()));

                    }

                }
            }
            doc.Add(table);
            doc.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //conn.Open();
            SqlCommand SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter();
            //string showdata = "SELECT Clo.Name AS CLO ,Rubric.Details AS Rubric, AssessmentComponent.TotalMarks AS Component_Marks, RubricLevel.MeasurementLevel AS Student_Rubric_Level ,((RubricLevel.MeasurementLevel*AssessmentComponent.TotalMarks)/4) AS ObtainedMarks from (((Clo inner join Rubric on Clo.Id=Rubric.CloId) inner join AssessmentComponent on Rubric.Id=AssessmentComponent.RubricId)inner join RubricLevel on  Rubric.Id=RubricLevel.RubricId)";
            string showdata = "SELECT Clo.Name AS CLO ,Rubric.Details AS Rubric, AssessmentComponent.TotalMarks AS Component_Marks, RubricLevel.MeasurementLevel AS Student_Rubric_Level ,((RubricLevel.MeasurementLevel*AssessmentComponent.TotalMarks)/4) AS ObtainedMarks from Clo inner join Rubric on Clo.Id=Rubric.CloId inner join AssessmentComponent on Rubric.Id=AssessmentComponent.RubricId inner join RubricLevel on  Rubric.Id=RubricLevel.RubricId"; 
            //string showdata = "SELECT Assessment.Title, Student.RegistrationNumber as RegNo, AssessmentComponent.Name as Component, Rubric.Details as Rubric, AssessmentComponent.TotalMarks, RubricLevel.MeasurementLevel FROM Assessment INNER JOIN AssessmentComponent ON Assessment.Id = AssessmentComponent.AssessmentId INNER JOIN Rubric ON AssessmentComponent.RubricId = Rubric.Id INNER JOIN StudentResult ON AssessmentComponent.Id = StudentResult.AssessmentComponentId INNER JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id INNER JOIN Student ON Student.Id = StudentResult.StudentId";
            SqlCommand = new SqlCommand(showdata, conn);
            adapter.SelectCommand = new SqlCommand(showdata, conn);
            DataTable dbdataset = new DataTable();
            adapter.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            dataGridView1.DataSource = bsource;
            DataGridViewTextBoxColumn ObtainedMarks = new DataGridViewTextBoxColumn();
            ObtainedMarks.HeaderText = "ObtainedMarks";
            dataGridView1.Columns.Add(ObtainedMarks);
            /*conn.Open();
            string query = "SELECT Clo.Name AS CLO ,Rubric.Details AS Rubric, AssessmentComponent.TotalMarks AS Component_Marks, RubricLevel.MeasurementLevel AS Student_Rubric_Level ,((RubricLevel.MeasurementLevel*AssessmentComponent.TotalMarks)/4) AS ObtainedMarks from (((Clo inner join Rubric on Clo.Id=Rubric.CloId) inner join AssessmentComponent on Rubric.Id=AssessmentComponent.RubricId)inner join RubricLevel on  Rubric.Id=RubricLevel.RubricId)";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //conn.Open();
            SqlCommand SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter();
            //string showdata = "SELECT Clo.Name AS CLO ,Rubric.Details AS Rubric, AssessmentComponent.TotalMarks AS Component_Marks, RubricLevel.MeasurementLevel AS Student_Rubric_Level ,((RubricLevel.MeasurementLevel*AssessmentComponent.TotalMarks)/4) AS ObtainedMarks from (((Clo inner join Rubric on Clo.Id=Rubric.CloId) inner join AssessmentComponent on Rubric.Id=AssessmentComponent.RubricId)inner join RubricLevel on  Rubric.Id=RubricLevel.RubricId)"; 
            string showdata = "SELECT Assessment.Title, Student.RegistrationNumber as RegNo, AssessmentComponent.Name as Component, Rubric.Details as Rubric, AssessmentComponent.TotalMarks, RubricLevel.MeasurementLevel FROM Assessment INNER JOIN AssessmentComponent ON Assessment.Id = AssessmentComponent.AssessmentId INNER JOIN Rubric ON AssessmentComponent.RubricId = Rubric.Id INNER JOIN StudentResult ON AssessmentComponent.Id = StudentResult.AssessmentComponentId INNER JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id INNER JOIN Student ON Student.Id = StudentResult.StudentId";
            SqlCommand = new SqlCommand(showdata, conn);
            adapter.SelectCommand = new SqlCommand(showdata, conn);
            DataTable dbdataset = new DataTable();
            adapter.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            dataGridView2.DataSource = bsource;
            DataGridViewTextBoxColumn ObtainedMarks = new DataGridViewTextBoxColumn();
            ObtainedMarks.HeaderText = "ObtainedMarks";
            dataGridView2.Columns.Add(ObtainedMarks);
            /*conn.Open();
            string query = "SELECT AssessmentComponent.Name AS Component ,Rubric.Details AS Rubric, AssessmentComponent.TotalMarks AS Component_Marks,((RubricLevel.MeasurementLevel*AssessmentComponent.TotalMarks)/4) AS ObtainedMarks,Student.FirstName,Student.Id  from StudentResult inner join Student on Student.Id=StudentResult.StudentId and Student.Id='" + comboBox1.SelectedValue + "' left join AssessmentComponent on StudentResult.AssessmentComponentId=AssessmentComponent.Id left join Rubric on Rubric.Id=AssessmentComponent.RubricId left join RubricLevel on  RubricLevel.Id=StudentResult.RubricMeasurementId";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //conn.Open();
            SqlCommand SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter();
            //string showdata = "SELECT Clo.Name AS CLO ,Rubric.Details AS Rubric, AssessmentComponent.TotalMarks AS Component_Marks, RubricLevel.MeasurementLevel AS Student_Rubric_Level ,((RubricLevel.MeasurementLevel*AssessmentComponent.TotalMarks)/4) AS ObtainedMarks from (((Clo inner join Rubric on Clo.Id=Rubric.CloId) inner join AssessmentComponent on Rubric.Id=AssessmentComponent.RubricId)inner join RubricLevel on  Rubric.Id=RubricLevel.RubricId)"; 
            string showdata = "SELECT Assessment.Title, Student.RegistrationNumber as RegNo, AssessmentComponent.Name as Component, Rubric.Details as Rubric, AssessmentComponent.TotalMarks, RubricLevel.MeasurementLevel FROM Assessment INNER JOIN AssessmentComponent ON Assessment.Id = AssessmentComponent.AssessmentId INNER JOIN Rubric ON AssessmentComponent.RubricId = Rubric.Id INNER JOIN StudentResult ON AssessmentComponent.Id = StudentResult.AssessmentComponentId INNER JOIN RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id INNER JOIN Student ON Student.Id = StudentResult.StudentId";
            SqlCommand = new SqlCommand(showdata, conn);
            adapter.SelectCommand = new SqlCommand(showdata, conn);
            DataTable dbdataset = new DataTable();
            adapter.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            dataGridView2.DataSource = bsource;
            DataGridViewTextBoxColumn ObtainedMarks = new DataGridViewTextBoxColumn();
            ObtainedMarks.HeaderText = "ObtainedMarks";
            dataGridView2.Columns.Add(ObtainedMarks);
            /*conn.Open();
            string query = "Insert INTO StudentResult(StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate) VALUES((select Id from Student where Id='" + comboBox1.SelectedValue + "'),(select Id from AssessmentComponent where Id='" + comboBox3.SelectedValue + "' ),(select Id from RubricLevel where RubricId='" + textBox2.Text + "'),'" + dateTimePicker1.Value.Date + "')";
            SqlCommand cmd3 = new SqlCommand(query, conn);
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Inserted Successfully!");*/
        }

        private void UserControl9_Load(object sender, EventArgs e)
        {
            //this.studentTableAdapter.Fill(this.projectBDataSet1.Student);
            
        }
        
    }
}
