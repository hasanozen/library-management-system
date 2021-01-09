using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entity;
using BL;

namespace SimpleLibraryManagementSystem
{
    public partial class FormStudent : WeifenLuo.WinFormsUI.DockContent
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        StudentOperations stdOpt = new StudentOperations();

        private void FormStudent_Load(object sender, EventArgs e)
        {
            //stdOpt = new StudentOperations();
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
            List<Students> students = stdOpt.Show();
            dgv_students.DataSource = students;
        }
        #endregion

        #region Clear TB
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

        private void tb_number_Click(object sender, EventArgs e)
        {
            tb_number.Text = "";
        }

        private void tb_dept_Click(object sender, EventArgs e)
        {
            tb_dept.Text = "";
        }
        #endregion

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Students> students = stdOpt.Show(tb_search.Text);
            dgv_students.DataSource = students;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                stdOpt.Add(tb_name.Text, tb_number.Text, tb_dept.Text);
            });
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                stdOpt.Update(int.Parse(tb_id.Text), tb_name.Text, tb_number.Text, tb_dept.Text);
            });
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                stdOpt.Delete(int.Parse(tb_id.Text));
            });
        }

        private void btn_allRecords_Click(object sender, EventArgs e)
        {
            ListItems();
        }

        private void dgv_students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_students.Rows[e.RowIndex];
                tb_id.Text = row.Cells[0].Value.ToString();
                tb_name.Text = row.Cells[1].Value.ToString();
                tb_number.Text = row.Cells[2].Value.ToString();
                tb_dept.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
