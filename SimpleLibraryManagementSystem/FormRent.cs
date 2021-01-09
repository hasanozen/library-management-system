using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entity;
using BL;

namespace SimpleLibraryManagementSystem
{
    public partial class FormRent : Form
    {
        public FormRent()
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
        private void tb_isValid_KeyPress(object sender, KeyPressEventArgs e)
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
            List<Rent> rents = rentOpr.LoadRent();
            dgv_info.DataSource = rents;
        }

        private void SetDataColor()
        {
            double penalty = 0;

            for (int i = 0; i < dgv_info.Rows.Count; i++)
            {
                penalty = double.Parse(dgv_info.Rows[i].Cells[5].Value.ToString());
                dgv_info.Rows[i].Cells[5].Value = penalty.ToString("c");

                string process_type = dgv_info.Rows[i].Cells[6].Value.ToString();

                if (process_type == "return")
                {
                    dgv_info.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgv_info.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                if (process_type != "return")
                {
                    string sTimeNow, sReturnTime;

                    sTimeNow = DateTime.Now.ToShortDateString();
                    sReturnTime = DateTime.Parse(dgv_info.Rows[i].Cells[3].Value.ToString()).ToShortDateString();

                    TimeSpan diff = DateTime.Parse(sTimeNow).Subtract(DateTime.Parse(sReturnTime));

                    if (Int32.Parse(diff.TotalDays.ToString()) > -3 &&
                        Int32.Parse(diff.TotalDays.ToString()) < 1)
                    {
                        dgv_info.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dgv_info.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }

                    if (Int32.Parse(diff.TotalDays.ToString()) > 0)
                    {
                        dgv_info.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgv_info.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
        #endregion

        string location = "";
        string table = "";

        RentOperations rentOpr;
        BookOperations bookOpr;
        StudentOperations stdOpr;

        private void FormRent_Load(object sender, EventArgs e)
        {
            rentOpr = new RentOperations();
            bookOpr = new BookOperations();
            stdOpr = new StudentOperations();

            string[] key = { "Book Name", "Author", "Type", "Number" };
            cb_c_type.Items.AddRange(key);
            cb_r_type.Items.AddRange(key);
        }

        private void btn_c_stdSearch_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                List<Students> students = stdOpr.Show(tb_c_stdNumber.Text);
                dgv_info.DataSource = students;
                table = "rent_students";

            });
        }

        #region Switch Case
        private void cb_c_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_c_type.SelectedItem.ToString())
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

        private void cb_r_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_c_type.SelectedItem.ToString())
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
        #endregion

        private void btn_c_bookSearch_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                List<Books> books = bookOpr.Show(tb_c_book.Text, location);
                dgv_info.DataSource = books;
                table = "rent_books";
            });
        }

        private void btn_consign_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                rentOpr.RentOperation(
                    int.Parse(tb_c_bookID.Text),
                    int.Parse(tb_c_stdID.Text),
                    DateTime.Parse(dtp_consign.Text),
                    DateTime.Parse(dtp_return.Text),
                    "consign"
                    );
            });
        }

        private void btn_r_stdSearch_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                List<Rent> data = rentOpr.ListRecords(int.Parse(tb_r_stdNumber.Text));
                dgv_info.DataSource = data;

            });
        }

        private void btn_r_bookSearch_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                List<Rent> data = rentOpr.ListWantedRecord(tb_r_book.Text, location);
                dgv_info.DataSource = data;
            });
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                rentOpr.RentEdit(
                    int.Parse(tb_r_bookID.Text), 
                    int.Parse(tb_r_stdID.Text), 
                    "return"
                    );
            });
        }

        private void btn_allRecords_Click(object sender, EventArgs e)
        {
            ListItems();
            SetDataColor();
        }
    }
}
