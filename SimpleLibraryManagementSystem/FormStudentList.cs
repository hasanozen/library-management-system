using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entity;
using BL;

namespace SimpleLibraryManagementSystem
{
    public partial class FormStudentList : Form
    {
        public FormStudentList()
        {
            InitializeComponent();
        }

        RentOperations rentOpr;
        private void FormStudentList_Load(object sender, EventArgs e)
        {
            if (rentOpr == null)
                rentOpr = new RentOperations();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Rent> data = rentOpr.ListStudentRent(tb_search.Text);
            dgv_list.DataSource = data;
        }

        private void btn_allRecords_Click(object sender, EventArgs e)
        {
            List<Rent> data = rentOpr.LoadRent();
            dgv_list.DataSource = data;
        }
    }
}
