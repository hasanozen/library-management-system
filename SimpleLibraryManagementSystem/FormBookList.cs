using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entity;
using BL;

namespace SimpleLibraryManagementSystem
{
    public partial class FormBookList : Form
    {
        public FormBookList()
        {
            InitializeComponent();
        }

        #region Exception Handling
        private void HandleException(Action action)
        {
            try
            {
                action.Invoke();
                MessageBox.Show("Success!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Process failed: \n" + e.Message);
            }
        }
        #endregion

        string location;
        RentOperations rentOpr;

        private void FormBookList_Load(object sender, EventArgs e)
        {
            if (rentOpr == null)
                rentOpr = new RentOperations();

            string[] filter = { "Book Name", "Author", "Type"};
            cb_filter.Items.AddRange(filter);
        }

        #region Switch Case
        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_filter.SelectedItem.ToString())
            {
                case "Book Name":
                    location = "book_name";
                    break;
                case "Author":
                    location = "author";
                    break;
                case "Type":
                    location = "tour";
                    break;
                default:
                    location = "book_name";
                    break;
            }
        }
        #endregion

        private void btn_search_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                List<Rent> data = rentOpr.ListWantedRecord(tb_search.Text, location);
                dgv_list.DataSource = data;
            });
        }

        private void btn_allRecords_Click(object sender, EventArgs e)
        {
            List<Rent> data = rentOpr.LoadRent();
            dgv_list.DataSource = data;
        }
    }
}
