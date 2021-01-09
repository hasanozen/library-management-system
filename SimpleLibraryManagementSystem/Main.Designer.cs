namespace SimpleLibraryManagementSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_book = new System.Windows.Forms.Button();
            this.btn_rent = new System.Windows.Forms.Button();
            this.btn_graphic = new System.Windows.Forms.Button();
            this.btn_stdRentList = new System.Windows.Forms.Button();
            this.btn_bookRentList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_student
            // 
            this.btn_student.Location = new System.Drawing.Point(13, 182);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(144, 60);
            this.btn_student.TabIndex = 0;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(163, 182);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(144, 60);
            this.btn_book.TabIndex = 1;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btn_rent
            // 
            this.btn_rent.Location = new System.Drawing.Point(313, 182);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(144, 60);
            this.btn_rent.TabIndex = 2;
            this.btn_rent.Text = "Rent";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // btn_graphic
            // 
            this.btn_graphic.Location = new System.Drawing.Point(313, 248);
            this.btn_graphic.Name = "btn_graphic";
            this.btn_graphic.Size = new System.Drawing.Size(144, 60);
            this.btn_graphic.TabIndex = 5;
            this.btn_graphic.Text = "Graphic";
            this.btn_graphic.UseVisualStyleBackColor = true;
            this.btn_graphic.Click += new System.EventHandler(this.btn_graphic_Click);
            // 
            // btn_stdRentList
            // 
            this.btn_stdRentList.Location = new System.Drawing.Point(163, 248);
            this.btn_stdRentList.Name = "btn_stdRentList";
            this.btn_stdRentList.Size = new System.Drawing.Size(144, 60);
            this.btn_stdRentList.TabIndex = 4;
            this.btn_stdRentList.Text = "Student Rent List";
            this.btn_stdRentList.UseVisualStyleBackColor = true;
            this.btn_stdRentList.Click += new System.EventHandler(this.btn_stdRentList_Click);
            // 
            // btn_bookRentList
            // 
            this.btn_bookRentList.Location = new System.Drawing.Point(13, 248);
            this.btn_bookRentList.Name = "btn_bookRentList";
            this.btn_bookRentList.Size = new System.Drawing.Size(144, 60);
            this.btn_bookRentList.TabIndex = 3;
            this.btn_bookRentList.Text = "Book Rent List";
            this.btn_bookRentList.UseVisualStyleBackColor = true;
            this.btn_bookRentList.Click += new System.EventHandler(this.btn_bookRentList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::SimpleLibraryManagementSystem.Properties.Resources.logo_lib;
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_graphic);
            this.Controls.Add(this.btn_stdRentList);
            this.Controls.Add(this.btn_bookRentList);
            this.Controls.Add(this.btn_rent);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.btn_student);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.Button btn_graphic;
        private System.Windows.Forms.Button btn_stdRentList;
        private System.Windows.Forms.Button btn_bookRentList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

