namespace MiniProject
{
    partial class UserControl2
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
            this.btnviewClo = new System.Windows.Forms.Button();
            this.btndelClo = new System.Windows.Forms.Button();
            this.btnupdClo = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnaddclo = new System.Windows.Forms.Button();
            this.txtClo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnviewClo
            // 
            this.btnviewClo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewClo.Location = new System.Drawing.Point(330, 228);
            this.btnviewClo.Name = "btnviewClo";
            this.btnviewClo.Size = new System.Drawing.Size(75, 34);
            this.btnviewClo.TabIndex = 19;
            this.btnviewClo.Text = "VIEW";
            this.btnviewClo.UseVisualStyleBackColor = true;
            this.btnviewClo.Click += new System.EventHandler(this.btnviewClo_Click);
            // 
            // btndelClo
            // 
            this.btndelClo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelClo.Location = new System.Drawing.Point(238, 228);
            this.btndelClo.Name = "btndelClo";
            this.btndelClo.Size = new System.Drawing.Size(86, 34);
            this.btndelClo.TabIndex = 18;
            this.btndelClo.Text = "DELETE CLO";
            this.btndelClo.UseVisualStyleBackColor = true;
            this.btndelClo.Click += new System.EventHandler(this.btndelClo_Click);
            // 
            // btnupdClo
            // 
            this.btnupdClo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdClo.Location = new System.Drawing.Point(140, 228);
            this.btnupdClo.Name = "btnupdClo";
            this.btnupdClo.Size = new System.Drawing.Size(92, 34);
            this.btnupdClo.TabIndex = 17;
            this.btnupdClo.Text = "UPDATE CLO";
            this.btnupdClo.UseVisualStyleBackColor = true;
            this.btnupdClo.Click += new System.EventHandler(this.btnupdClo_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(465, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(342, 236);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Register CLO\'s";
            // 
            // btnaddclo
            // 
            this.btnaddclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddclo.Location = new System.Drawing.Point(59, 228);
            this.btnaddclo.Name = "btnaddclo";
            this.btnaddclo.Size = new System.Drawing.Size(75, 34);
            this.btnaddclo.TabIndex = 14;
            this.btnaddclo.Text = "ADD CLO";
            this.btnaddclo.UseVisualStyleBackColor = true;
            this.btnaddclo.Click += new System.EventHandler(this.btnaddclo_Click);
            // 
            // txtClo
            // 
            this.txtClo.Location = new System.Drawing.Point(167, 99);
            this.txtClo.Name = "txtClo";
            this.txtClo.Size = new System.Drawing.Size(263, 83);
            this.txtClo.TabIndex = 13;
            this.txtClo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "CLO Name";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnviewClo);
            this.Controls.Add(this.btndelClo);
            this.Controls.Add(this.btnupdClo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnaddclo);
            this.Controls.Add(this.txtClo);
            this.Controls.Add(this.label2);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(908, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnviewClo;
        private System.Windows.Forms.Button btndelClo;
        private System.Windows.Forms.Button btnupdClo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnaddclo;
        private System.Windows.Forms.RichTextBox txtClo;
        private System.Windows.Forms.Label label2;
    }
}
