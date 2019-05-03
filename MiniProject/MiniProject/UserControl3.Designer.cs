namespace MiniProject
{
    partial class UserControl3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new MiniProject.ProjectBDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cloTableAdapter = new MiniProject.ProjectBDataSetTableAdapters.CloTableAdapter();
            this.projectBDataSet4 = new MiniProject.ProjectBDataSet4();
            this.cloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cloTableAdapter1 = new MiniProject.ProjectBDataSet4TableAdapters.CloTableAdapter();
            this.projectBDataSet5 = new MiniProject.ProjectBDataSet5();
            this.cloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cloTableAdapter2 = new MiniProject.ProjectBDataSet5TableAdapters.CloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Rubrics";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "CloId";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.cloBindingSource2;
            this.comboBox2.DisplayMember = "Id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.ValueMember = "Id";
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(269, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 22;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(188, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 21;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(102, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 45);
            this.button2.TabIndex = 20;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(167, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 96);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(437, 55);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(365, 227);
            this.dataGridView3.TabIndex = 17;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(33, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rubric Detail";
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // projectBDataSet4
            // 
            this.projectBDataSet4.DataSetName = "ProjectBDataSet4";
            this.projectBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource1
            // 
            this.cloBindingSource1.DataMember = "Clo";
            this.cloBindingSource1.DataSource = this.projectBDataSet4;
            // 
            // cloTableAdapter1
            // 
            this.cloTableAdapter1.ClearBeforeFill = true;
            // 
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource2
            // 
            this.cloBindingSource2.DataMember = "Clo";
            this.cloBindingSource2.DataSource = this.projectBDataSet5;
            this.cloBindingSource2.CurrentChanged += new System.EventHandler(this.cloBindingSource2_CurrentChanged);
            // 
            // cloTableAdapter2
            // 
            this.cloTableAdapter2.ClearBeforeFill = true;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label6);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(867, 431);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSet projectBDataSet;
        private ProjectBDataSetTableAdapters.CloTableAdapter cloTableAdapter;
        private System.Windows.Forms.BindingSource cloBindingSource1;
        private ProjectBDataSet4 projectBDataSet4;
        private ProjectBDataSet4TableAdapters.CloTableAdapter cloTableAdapter1;
        private System.Windows.Forms.BindingSource cloBindingSource2;
        private ProjectBDataSet5 projectBDataSet5;
        private ProjectBDataSet5TableAdapters.CloTableAdapter cloTableAdapter2;
    }
}
