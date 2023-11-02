using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using
using System.Data.SqlClient;

namespace ProjectUAS
{
    public partial class FormPengembalian : Form
    {
        public FormPengembalian()
        {
            InitializeComponent();
        }

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader sdr;

        Koneksi Konn = new Koneksi();

        void TampilkanPinjaman()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT RentID, RentDate AS [Tanggal Peminjaman], RentDueDate AS [Batas Peminjaman], RentLateFee AS Denda FROM TBL_Rent WHERE UserID LIKE '%" + FormLogin.UserInfo.savedUserID + "%' AND RentStatus='1'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Rent");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Rent";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        void TampilkanBuku()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT RD.RentID, B.BookID, B.BookTitle, B.BookAuthor, B.BookType, B.ShelfID FROM TBL_RentDetail RD INNER JOIN TBL_Buku B ON RD.BookID = B.BookID WHERE RentID='" + txtRentID.Text + "' ORDER BY B.BookID;", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_RentDetail");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_RentDetail";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            TampilkanPinjaman();
            txtDateToday.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        // Menampilkan daftar buku yang dipinjam
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtRentID.Text = row.Cells["RentID"].Value.ToString();
                txtRentDate.Text = row.Cells["Tanggal Peminjaman"].Value.ToString().Remove(10);
                txtRentDueDate.Text = row.Cells["Batas Peminjaman"].Value.ToString().Remove(10);
                conn.Open();
                
                int selisihHari = Convert.ToInt32((DateTime.Now.Date - Convert.ToDateTime(txtRentDueDate.Text).Date).Days);
                if (selisihHari > 0)
                {
                    int jumlahDenda = selisihHari * 5000;
                    cmd = new SqlCommand("UPDATE TBL_Rent SET RentLateFee=" + jumlahDenda + " WHERE RentID='" + txtRentID.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    txtRentLateFee.Text = jumlahDenda.ToString();
                }
                else
                {
                    txtRentLateFee.Text = row.Cells["Denda"].Value.ToString();
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
            conn.Close();

            TampilkanPinjaman();
            TampilkanBuku();
        }

        private void btnTampilkanPeminjaman_Click(object sender, EventArgs e)
        {
            TampilkanPinjaman();
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin mengembalikan pinjaman?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    string strRentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string strRentDueDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                    conn.Open();
                    cmd = new SqlCommand("UPDATE TBL_Rent SET RentStatus=0 WHERE RentID='" + txtRentID.Text + "'; " +
                        "UPDATE TBL_Buku SET BookStatus = 1 WHERE BookID IN (SELECT BookID FROM TBL_RentDetail WHERE RentID='" + txtRentID.Text + "'); ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    TampilkanPinjaman();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void btnTampilkanBuku_Click(object sender, EventArgs e)
        {
            TampilkanBuku();
        }
    }
}
