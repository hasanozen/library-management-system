using System;
using System.Windows.Forms;

namespace SimpleLibraryManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent();
            form.Show();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            FormBook form = new FormBook();
            form.Show();
        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            FormRent form = new FormRent();
            form.Show();
        }

        private void btn_bookRentList_Click(object sender, EventArgs e)
        {
            FormBookList form = new FormBookList();
            form.Show();
        }

        private void btn_stdRentList_Click(object sender, EventArgs e)
        {
            FormStudentList form = new FormStudentList();
            form.Show();
        }

        private void btn_graphic_Click(object sender, EventArgs e)
        {
            FormGraphic form = new FormGraphic();
            form.Show();
        }
    }
}
