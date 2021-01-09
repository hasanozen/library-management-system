using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BL;
using Entity;

namespace SimpleLibraryManagementSystem
{
    public partial class FormBook : Form
    {
        public FormBook()
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

        #region Text Input Control
        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region External Methods
        private void ListItems()
        {
            List<Books> books = bookOpr.Show();
            dgv_bookList.DataSource = books;
        }
        #endregion

        string location;
        BookOperations bookOpr;

        private void FormBook_Load(object sender, EventArgs e)
        {
            bookOpr = new BookOperations();
            location = "";

            string[] key = { "Book Name", "Author", "Type", "Number" };
            cb_key.Items.AddRange(key);
        }

        private void cb_key_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_key.SelectedItem.ToString())
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
                case "Number":
                    location = "book_number";
                    break;
                default:
                    break;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                List<Books> books = bookOpr.Show(tb_search.Text, location);
                dgv_bookList.DataSource = books;
            });
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                bookOpr.Add(tb_name.Text, tb_author.Text, tb_number.Text, tb_type.Text);
            });
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                bookOpr.Update(int.Parse(tb_id.Text), tb_name.Text, tb_author.Text, tb_number.Text, tb_type.Text);
            });
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                bookOpr.Delete(int.Parse(tb_id.Text));
            });
        }

        private void btn_allRecords_Click(object sender, EventArgs e)
        {
            ListItems();
        }

        private void dgv_bookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_bookList.Rows[e.RowIndex];
                tb_id.Text = row.Cells[0].Value.ToString();
                tb_name.Text = row.Cells[1].Value.ToString();
                tb_author.Text = row.Cells[2].Value.ToString();
                tb_number.Text = row.Cells[3].Value.ToString();
                tb_type.Text = row.Cells[4].Value.ToString();
            }
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }

        private void tb_id_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
        }

        private void tb_name_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
        }

        private void tb_author_Click(object sender, EventArgs e)
        {
            tb_author.Text = "";
        }

        private void tb_number_Click(object sender, EventArgs e)
        {
            tb_number.Text = "";
        }

        private void tb_type_Click(object sender, EventArgs e)
        {
            tb_type.Text = "";
        }
    }
}
