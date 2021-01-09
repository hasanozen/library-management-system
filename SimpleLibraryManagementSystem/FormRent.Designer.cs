namespace SimpleLibraryManagementSystem
{
    partial class FormRent
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
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.btn_allRecords = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_consign = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            this.dtp_consign = new System.Windows.Forms.DateTimePicker();
            this.tb_c_bookID = new System.Windows.Forms.TextBox();
            this.tb_c_stdID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_c_type = new System.Windows.Forms.ComboBox();
            this.btn_c_bookSearch = new System.Windows.Forms.Button();
            this.tb_c_book = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_c_stdSearch = new System.Windows.Forms.Button();
            this.tb_c_stdNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_r_stdID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_r_bookID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_r_type = new System.Windows.Forms.ComboBox();
            this.btn_r_bookSearch = new System.Windows.Forms.Button();
            this.tb_r_book = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_r_stdSearch = new System.Windows.Forms.Button();
            this.tb_r_stdNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_info
            // 
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(522, 12);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.Size = new System.Drawing.Size(493, 460);
            this.dgv_info.TabIndex = 2;
            // 
            // btn_allRecords
            // 
            this.btn_allRecords.Location = new System.Drawing.Point(522, 478);
            this.btn_allRecords.Name = "btn_allRecords";
            this.btn_allRecords.Size = new System.Drawing.Size(493, 46);
            this.btn_allRecords.TabIndex = 3;
            this.btn_allRecords.Text = "Show All Records";
            this.btn_allRecords.UseVisualStyleBackColor = true;
            this.btn_allRecords.Click += new System.EventHandler(this.btn_allRecords_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_consign);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 253);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONSIGN OPERATIONS";
            // 
            // btn_consign
            // 
            this.btn_consign.Location = new System.Drawing.Point(212, 184);
            this.btn_consign.Name = "btn_consign";
            this.btn_consign.Size = new System.Drawing.Size(283, 58);
            this.btn_consign.TabIndex = 12;
            this.btn_consign.Text = "Consign";
            this.btn_consign.UseVisualStyleBackColor = true;
            this.btn_consign.Click += new System.EventHandler(this.btn_consign_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_return);
            this.groupBox3.Controls.Add(this.dtp_consign);
            this.groupBox3.Controls.Add(this.tb_c_bookID);
            this.groupBox3.Controls.Add(this.tb_c_stdID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(212, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 143);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consign";
            // 
            // dtp_return
            // 
            this.dtp_return.Location = new System.Drawing.Point(74, 108);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(200, 20);
            this.dtp_return.TabIndex = 7;
            // 
            // dtp_consign
            // 
            this.dtp_consign.Location = new System.Drawing.Point(74, 82);
            this.dtp_consign.Name = "dtp_consign";
            this.dtp_consign.Size = new System.Drawing.Size(200, 20);
            this.dtp_consign.TabIndex = 6;
            // 
            // tb_c_bookID
            // 
            this.tb_c_bookID.Location = new System.Drawing.Point(73, 56);
            this.tb_c_bookID.Name = "tb_c_bookID";
            this.tb_c_bookID.Size = new System.Drawing.Size(201, 20);
            this.tb_c_bookID.TabIndex = 5;
            this.tb_c_bookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_isValid_KeyPress);
            // 
            // tb_c_stdID
            // 
            this.tb_c_stdID.Location = new System.Drawing.Point(73, 30);
            this.tb_c_stdID.Name = "tb_c_stdID";
            this.tb_c_stdID.Size = new System.Drawing.Size(201, 20);
            this.tb_c_stdID.TabIndex = 4;
            this.tb_c_stdID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_isValid_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Return:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Consign:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Book ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_c_type);
            this.groupBox2.Controls.Add(this.btn_c_bookSearch);
            this.groupBox2.Controls.Add(this.tb_c_book);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 115);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type:";
            // 
            // cb_c_type
            // 
            this.cb_c_type.FormattingEnabled = true;
            this.cb_c_type.Location = new System.Drawing.Point(56, 30);
            this.cb_c_type.Name = "cb_c_type";
            this.cb_c_type.Size = new System.Drawing.Size(138, 21);
            this.cb_c_type.TabIndex = 3;
            this.cb_c_type.SelectedIndexChanged += new System.EventHandler(this.cb_c_type_SelectedIndexChanged);
            // 
            // btn_c_bookSearch
            // 
            this.btn_c_bookSearch.Location = new System.Drawing.Point(6, 83);
            this.btn_c_bookSearch.Name = "btn_c_bookSearch";
            this.btn_c_bookSearch.Size = new System.Drawing.Size(188, 23);
            this.btn_c_bookSearch.TabIndex = 2;
            this.btn_c_bookSearch.Text = "Search";
            this.btn_c_bookSearch.UseVisualStyleBackColor = true;
            this.btn_c_bookSearch.Click += new System.EventHandler(this.btn_c_bookSearch_Click);
            // 
            // tb_c_book
            // 
            this.tb_c_book.Location = new System.Drawing.Point(56, 57);
            this.tb_c_book.Name = "tb_c_book";
            this.tb_c_book.Size = new System.Drawing.Size(138, 20);
            this.tb_c_book.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_c_stdSearch);
            this.groupBox4.Controls.Add(this.tb_c_stdNumber);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 86);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Student";
            // 
            // btn_c_stdSearch
            // 
            this.btn_c_stdSearch.Location = new System.Drawing.Point(6, 56);
            this.btn_c_stdSearch.Name = "btn_c_stdSearch";
            this.btn_c_stdSearch.Size = new System.Drawing.Size(188, 23);
            this.btn_c_stdSearch.TabIndex = 2;
            this.btn_c_stdSearch.Text = "Search";
            this.btn_c_stdSearch.UseVisualStyleBackColor = true;
            this.btn_c_stdSearch.Click += new System.EventHandler(this.btn_c_stdSearch_Click);
            // 
            // tb_c_stdNumber
            // 
            this.tb_c_stdNumber.Location = new System.Drawing.Point(56, 30);
            this.tb_c_stdNumber.Name = "tb_c_stdNumber";
            this.tb_c_stdNumber.Size = new System.Drawing.Size(138, 20);
            this.tb_c_stdNumber.TabIndex = 1;
            this.tb_c_stdNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_isValid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_return);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Location = new System.Drawing.Point(12, 271);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(504, 253);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RETURN OPERATIONS";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(212, 186);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(283, 58);
            this.btn_return.TabIndex = 13;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_r_stdID);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.tb_r_bookID);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(212, 37);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(283, 143);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Search Book";
            // 
            // tb_r_stdID
            // 
            this.tb_r_stdID.Location = new System.Drawing.Point(56, 31);
            this.tb_r_stdID.Name = "tb_r_stdID";
            this.tb_r_stdID.Size = new System.Drawing.Size(221, 20);
            this.tb_r_stdID.TabIndex = 5;
            this.tb_r_stdID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_isValid_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Std ID:";
            // 
            // tb_r_bookID
            // 
            this.tb_r_bookID.Location = new System.Drawing.Point(56, 57);
            this.tb_r_bookID.Name = "tb_r_bookID";
            this.tb_r_bookID.Size = new System.Drawing.Size(221, 20);
            this.tb_r_bookID.TabIndex = 1;
            this.tb_r_bookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_isValid_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Book ID:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.cb_r_type);
            this.groupBox7.Controls.Add(this.btn_r_bookSearch);
            this.groupBox7.Controls.Add(this.tb_r_book);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(6, 129);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 115);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Search Book";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Type:";
            // 
            // cb_r_type
            // 
            this.cb_r_type.FormattingEnabled = true;
            this.cb_r_type.Location = new System.Drawing.Point(56, 30);
            this.cb_r_type.Name = "cb_r_type";
            this.cb_r_type.Size = new System.Drawing.Size(138, 21);
            this.cb_r_type.TabIndex = 3;
            this.cb_r_type.SelectedIndexChanged += new System.EventHandler(this.cb_r_type_SelectedIndexChanged);
            // 
            // btn_r_bookSearch
            // 
            this.btn_r_bookSearch.Location = new System.Drawing.Point(6, 83);
            this.btn_r_bookSearch.Name = "btn_r_bookSearch";
            this.btn_r_bookSearch.Size = new System.Drawing.Size(188, 23);
            this.btn_r_bookSearch.TabIndex = 2;
            this.btn_r_bookSearch.Text = "Search";
            this.btn_r_bookSearch.UseVisualStyleBackColor = true;
            this.btn_r_bookSearch.Click += new System.EventHandler(this.btn_r_bookSearch_Click);
            // 
            // tb_r_book
            // 
            this.tb_r_book.Location = new System.Drawing.Point(56, 57);
            this.tb_r_book.Name = "tb_r_book";
            this.tb_r_book.Size = new System.Drawing.Size(138, 20);
            this.tb_r_book.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Book:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btn_r_stdSearch);
            this.groupBox8.Controls.Add(this.tb_r_stdNumber);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(6, 37);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 86);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Search Student";
            // 
            // btn_r_stdSearch
            // 
            this.btn_r_stdSearch.Location = new System.Drawing.Point(6, 56);
            this.btn_r_stdSearch.Name = "btn_r_stdSearch";
            this.btn_r_stdSearch.Size = new System.Drawing.Size(188, 23);
            this.btn_r_stdSearch.TabIndex = 2;
            this.btn_r_stdSearch.Text = "Search";
            this.btn_r_stdSearch.UseVisualStyleBackColor = true;
            this.btn_r_stdSearch.Click += new System.EventHandler(this.btn_r_stdSearch_Click);
            // 
            // tb_r_stdNumber
            // 
            this.tb_r_stdNumber.Location = new System.Drawing.Point(56, 30);
            this.tb_r_stdNumber.Name = "tb_r_stdNumber";
            this.tb_r_stdNumber.Size = new System.Drawing.Size(138, 20);
            this.tb_r_stdNumber.TabIndex = 1;
            this.tb_r_stdNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_isValid_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Number:";
            // 
            // FormRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 535);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_allRecords);
            this.Controls.Add(this.dgv_info);
            this.Name = "FormRent";
            this.Text = "FormRent";
            this.Load += new System.EventHandler(this.FormRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Button btn_allRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_consign;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_return;
        private System.Windows.Forms.DateTimePicker dtp_consign;
        private System.Windows.Forms.TextBox tb_c_bookID;
        private System.Windows.Forms.TextBox tb_c_stdID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_c_type;
        private System.Windows.Forms.Button btn_c_bookSearch;
        private System.Windows.Forms.TextBox tb_c_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_c_stdSearch;
        private System.Windows.Forms.TextBox tb_c_stdNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_r_stdID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_r_bookID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_r_type;
        private System.Windows.Forms.Button btn_r_bookSearch;
        private System.Windows.Forms.TextBox tb_r_book;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btn_r_stdSearch;
        private System.Windows.Forms.TextBox tb_r_stdNumber;
        private System.Windows.Forms.Label label12;
    }
}