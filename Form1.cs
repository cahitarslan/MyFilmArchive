using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MyFilmArchive
{
    public partial class Form1 : Form
    {
        string _connectionString = @"data source=(localdb)\mssqllocaldb;initial catalog=MovieArchive;integrated security=false;uid=sa;pwd=1";

        public Form1()
        {
            InitializeComponent();
        }

        void PopulateCategoryComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Categories", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                cbxCategory.ValueMember = "CategoryId";
                cbxCategory.DisplayMember = "CategoryName";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                cbxCategory.DataSource = dtbl;
            }
        }

        string Link;
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCategoryComboBox();
            PopulateDataGridView();

            DataGridViewRow dgvRow = dgwMovieList.CurrentRow;
            Link = dgvRow.Cells["tbxLink"].Value.ToString();
        }

        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Movies", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgwMovieList.DataSource = dtbl;
            }

        }

        private void dgwMovieList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwMovieList.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(_connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgwMovieList.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("MovieAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["tbxMovieId"].Value == DBNull.Value)   //Insert
                        sqlCmd.Parameters.AddWithValue("@movieId", 0);
                    else   //Update
                        sqlCmd.Parameters.AddWithValue("@movieId", Convert.ToInt32(dgvRow.Cells["tbxMovieId"].Value));
                    sqlCmd.Parameters.AddWithValue("@filmName", dgvRow.Cells["tbxName"].Value == DBNull.Value ? "" : dgvRow.Cells["tbxName"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@categoryId", Convert.ToInt32(dgvRow.Cells["cbxCategory"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxCategory"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@link", dgvRow.Cells["tbxLink"].Value == DBNull.Value ? "" : dgvRow.Cells["tbxLink"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@viewed", Convert.ToBoolean(dgvRow.Cells["chkViewed"].Value == DBNull.Value ? "False" : dgvRow.Cells["chkViewed"].Value.ToString()));
                    sqlCmd.ExecuteNonQuery();

                    PopulateDataGridView();
                }
            }
        }

        private void dgwMovieList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowLettersOnly;
            if (dgwMovieList.CurrentCell.ColumnIndex == 1 || dgwMovieList.CurrentCell.ColumnIndex == 3)
            {
                e.Control.KeyPress += AllowLettersOnly;
            }
        }

        private void AllowLettersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void dgwMovieList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }


        private void btnWatch_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgwMovieList.CurrentRow;
            if (dgvRow.Cells["tbxLink"].Value == DBNull.Value)
                MessageBox.Show("Invalid link!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                webBrowser1.Navigate(Link);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgwMovieList.CurrentRow;
            Form2 frm2 = new Form2();
            if (dgvRow.Cells["tbxLink"].Value == DBNull.Value)
            {
                if (this.BackColor == Color.Black)
                    frm2.BackColor = Color.Black;
                else
                    frm2.BackColor = Color.White;

                frm2.Show();
                MessageBox.Show("Invalid link!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                webBrowser1.Dispose();
                frm2.Show();
                frm2.webBrowser1.Navigate(Link);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            panel1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            dgwMovieList.BackgroundColor = Color.White;
            btnWatch.ForeColor = Color.Black;
            btnWatch.FlatAppearance.BorderColor = Color.Black;
            btnMaximize.ForeColor = Color.Black;
            btnMaximize.FlatAppearance.BorderColor = Color.Black;
            btnClose.ForeColor = Color.Black;
            btnClose.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            panel1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            dgwMovieList.BackgroundColor = Color.Black;
            btnWatch.ForeColor = Color.White;
            btnWatch.FlatAppearance.BorderColor = Color.White;
            btnMaximize.ForeColor = Color.White;
            btnMaximize.FlatAppearance.BorderColor = Color.White;
            btnClose.ForeColor = Color.White;
            btnClose.FlatAppearance.BorderColor = Color.White;
        }

        private void dgwMovieList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgwMovieList.CurrentRow;
            Link = dgvRow.Cells["tbxLink"].Value.ToString();
        }
    }
}
