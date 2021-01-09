namespace SimpleLibraryManagementSystem
{
    partial class FormBook
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
            this.btn_allRecords = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_key = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dgv_bookList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gb_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_allRecords
            // 
            this.btn_allRecords.Location = new System.Drawing.Point(18, 198);
            this.btn_allRecords.Name = "btn_allRecords";
            this.btn_allRecords.Size = new System.Drawing.Size(187, 23);
            this.btn_allRecords.TabIndex = 6;
            this.btn_allRecords.Text = "Show All Record";
            this.btn_allRecords.UseVisualStyleBackColor = true;
            this.btn_allRecords.Click += new System.EventHandler(this.btn_allRecords_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_type);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.tb_number);
            this.groupBox1.Controls.Add(this.tb_author);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(219, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Informations";
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(117, 144);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(265, 20);
            this.tb_type.TabIndex = 12;
            this.tb_type.Click += new System.EventHandler(this.tb_type_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type:";
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
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(117, 118);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(265, 20);
            this.tb_number.TabIndex = 7;
            this.tb_number.Click += new System.EventHandler(this.tb_number_Click);
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(117, 92);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(265, 20);
            this.tb_author.TabIndex = 6;
            this.tb_author.Click += new System.EventHandler(this.tb_author_Click);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author:";
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
            // gb_search
            // 
            this.gb_search.Controls.Add(this.label5);
            this.gb_search.Controls.Add(this.cb_key);
            this.gb_search.Controls.Add(this.btn_search);
            this.gb_search.Controls.Add(this.tb_search);
            this.gb_search.Location = new System.Drawing.Point(12, 12);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(200, 180);
            this.gb_search.TabIndex = 4;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Search Key";
            // 
            // cb_key
            // 
            this.cb_key.FormattingEnabled = true;
            this.cb_key.Location = new System.Drawing.Point(6, 53);
            this.cb_key.Name = "cb_key";
            this.cb_key.Size = new System.Drawing.Size(188, 21);
            this.cb_key.TabIndex = 2;
            this.cb_key.SelectedIndexChanged += new System.EventHandler(this.cb_key_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(6, 131);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(187, 43);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_search.Location = new System.Drawing.Point(6, 80);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(187, 20);
            this.tb_search.TabIndex = 0;
            this.tb_search.Text = "Book Information";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            // 
            // dgv_bookList
            // 
            this.dgv_bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bookList.Location = new System.Drawing.Point(12, 233);
            this.dgv_bookList.Name = "dgv_bookList";
            this.dgv_bookList.Size = new System.Drawing.Size(597, 389);
            this.dgv_bookList.TabIndex = 7;
            this.dgv_bookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bookList_CellContentClick);
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 634);
            this.Controls.Add(this.dgv_bookList);
            this.Controls.Add(this.btn_allRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_search);
            this.Name = "FormBook";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_allRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_key;
        private System.Windows.Forms.DataGridView dgv_bookList;
    }
}