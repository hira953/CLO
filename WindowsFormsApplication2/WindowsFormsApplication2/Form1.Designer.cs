namespace WindowsFormsApplication2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.labLastName = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtClo = new System.Windows.Forms.RichTextBox();
            this.btnaddclo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnupdClo = new System.Windows.Forms.Button();
            this.btndelClo = new System.Windows.Forms.Button();
            this.btnviewClo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.lblId);
            this.tabPage1.Controls.Add(this.btnView);
            this.tabPage1.Controls.Add(this.txtStatus);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtRegNumber);
            this.tabPage1.Controls.Add(this.lblRegNumber);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtContact);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblContact);
            this.tabPage1.Controls.Add(this.labLastName);
            this.tabPage1.Controls.Add(this.labFirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1046, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student Registration";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(180, 30);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(48, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(277, 257);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(180, 216);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(48, 223);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(634, 242);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(196, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(180, 186);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRegNumber.TabIndex = 9;
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(48, 189);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(103, 13);
            this.lblRegNumber.TabIndex = 8;
            this.lblRegNumber.Text = "Registration Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(180, 126);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(180, 89);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(180, 59);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(48, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(48, 133);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact";
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Location = new System.Drawing.Point(48, 96);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(58, 13);
            this.labLastName.TabIndex = 1;
            this.labLastName.Text = "Last Name";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(48, 66);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(57, 13);
            this.labFirstName.TabIndex = 0;
            this.labFirstName.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnviewClo);
            this.tabPage2.Controls.Add(this.btndelClo);
            this.tabPage2.Controls.Add(this.btnupdClo);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnaddclo);
            this.tabPage2.Controls.Add(this.txtClo);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1046, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLO Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date Created";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Updated";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(158, 188);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // txtClo
            // 
            this.txtClo.Location = new System.Drawing.Point(158, 66);
            this.txtClo.Name = "txtClo";
            this.txtClo.Size = new System.Drawing.Size(243, 63);
            this.txtClo.TabIndex = 5;
            this.txtClo.Text = "";
            // 
            // btnaddclo
            // 
            this.btnaddclo.Location = new System.Drawing.Point(50, 254);
            this.btnaddclo.Name = "btnaddclo";
            this.btnaddclo.Size = new System.Drawing.Size(75, 23);
            this.btnaddclo.TabIndex = 6;
            this.btnaddclo.Text = "ADD CLO";
            this.btnaddclo.UseVisualStyleBackColor = true;
            this.btnaddclo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Register CLO\'s";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(453, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(578, 236);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
            // 
            // btnupdClo
            // 
            this.btnupdClo.Location = new System.Drawing.Point(131, 254);
            this.btnupdClo.Name = "btnupdClo";
            this.btnupdClo.Size = new System.Drawing.Size(92, 23);
            this.btnupdClo.TabIndex = 9;
            this.btnupdClo.Text = "UPDATE CLO";
            this.btnupdClo.UseVisualStyleBackColor = true;
            this.btnupdClo.Click += new System.EventHandler(this.btnupdClo_Click);
            // 
            // btndelClo
            // 
            this.btndelClo.Location = new System.Drawing.Point(229, 254);
            this.btndelClo.Name = "btndelClo";
            this.btndelClo.Size = new System.Drawing.Size(75, 23);
            this.btndelClo.TabIndex = 10;
            this.btndelClo.Text = "DELETE CLO";
            this.btndelClo.UseVisualStyleBackColor = true;
            // 
            // btnviewClo
            // 
            this.btnviewClo.Location = new System.Drawing.Point(310, 254);
            this.btnviewClo.Name = "btnviewClo";
            this.btnviewClo.Size = new System.Drawing.Size(75, 23);
            this.btnviewClo.TabIndex = 11;
            this.btnviewClo.Text = "VIEW";
            this.btnviewClo.UseVisualStyleBackColor = true;
            this.btnviewClo.Click += new System.EventHandler(this.btnviewClo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 324);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnaddclo;
        private System.Windows.Forms.RichTextBox txtClo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnviewClo;
        private System.Windows.Forms.Button btndelClo;
        private System.Windows.Forms.Button btnupdClo;
    }
}

