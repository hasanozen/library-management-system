namespace SimpleLibraryManagementSystem
{
    partial class FormStudent
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
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_dept = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.btn_allRecords = new System.Windows.Forms.Button();
            this.gb_search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.btn_search);
            this.gb_search.Controls.Add(this.tb_search);
            this.gb_search.Location = new System.Drawing.Point(12, 12);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(200, 120);
            this.gb_search.TabIndex = 0;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(6, 67);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(187, 43);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tb_search.Location = new System.Drawing.Point(6, 41);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(187, 20);
            this.tb_search.TabIndex = 0;
            this.tb_search.Text = "Enter Student Number";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.tb_dept);
            this.groupBox1.Controls.Add(this.tb_number);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(219, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Informations";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(307, 185);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(88, 185);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(7, 185);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_dept
            // 
            this.tb_dept.Location = new System.Drawing.Point(117, 118);
            this.tb_dept.Name = "tb_dept";
            this.tb_dept.Size = new System.Drawing.Size(265, 20);
            this.tb_dept.TabIndex = 7;
            this.tb_dept.Click += new System.EventHandler(this.tb_dept_Click);
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(117, 92);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(265, 20);
            this.tb_number.TabIndex = 6;
            this.tb_number.Click += new System.EventHandler(this.tb_number_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(117, 66);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(265, 20);
            this.tb_name.TabIndex = 5;
            this.tb_name.Click += new System.EventHandler(this.tb_name_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(117, 40);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(265, 20);
            this.tb_id.TabIndex = 4;
            this.tb_id.Click += new System.EventHandler(this.tb_id_Click);
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgv_students
            // 
            this.dgv_students.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Location = new System.Drawing.Point(12, 233);
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.Size = new System.Drawing.Size(604, 328);
            this.dgv_students.TabIndex = 2;
            this.dgv_students.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_students_CellContentClick);
            // 
            // btn_allRecords
            // 
            this.btn_allRecords.Location = new System.Drawing.Point(18, 198);
            this.btn_allRecords.Name = "btn_allRecords";
            this.btn_allRecords.Size = new System.Drawing.Size(187, 23);
            this.btn_allRecords.TabIndex = 3;
            this.btn_allRecords.Text = "Show All Record";
            this.btn_allRecords.UseVisualStyleBackColor = true;
            this.btn_allRecords.Click += new System.EventHandler(this.btn_allRecords_Click);
            // 
            // FormStudent
            // 
            this.ClientSize = new System.Drawing.Size(628, 573);
            this.Controls.Add(this.btn_allRecords);
            this.Controls.Add(this.dgv_students);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_search);
            this.HideOnClose = true;
            this.Name = "FormStudent";
            this.TabText = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_dept;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_students;
        private System.Windows.Forms.Button btn_allRecords;
    }
}
