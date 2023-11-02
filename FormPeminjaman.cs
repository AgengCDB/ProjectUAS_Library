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
    public partial class FormPeminjaman : Form
    {
        public FormPeminjaman()
        {
            InitializeComponent();
        }

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader sdr;

        Koneksi Konn = new Koneksi();

        void IsiDataUser()
        {
            txtUserID.Text = FormLogin.UserInfo.savedUserID.ToString();
            txtName.Text = FormLogin.UserInfo.savedUserName.ToString();
            txtAlamat.Text = FormLogin.UserInfo.savedUserAddress.ToString();
            txtTelepon.Text = FormLogin.UserInfo.savedUserPhone.ToString();
        }

        void TampilTabel()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_Buku where BookStatus=1", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Buku");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Buku";
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

        void CariTabel()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_Buku where BookTitle like '%" + txtJudul.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Buku");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Buku";
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

        void CekPeminjaman()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_Rent where UserID like '%" + txtUserID.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Rent");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "TBL_Rent";
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void CekRentDetail()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT RD.RentID, B.BookID, B.BookTitle, B.BookAuthor, B.BookType, B.ShelfID FROM TBL_RentDetail RD INNER JOIN TBL_Buku B ON RD.BookID = B.BookID WHERE RentID like '%" + txtRentID.Text + "%' ORDER BY B.BookID", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_RentDetail");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "TBL_RentDetail";
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void UpdateRentID()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT TOP 1 RentID FROM TBL_Rent ORDER BY RentID DESC", conn);
            if (cmd.ExecuteScalar() == null)
            {
                txtRentID.Text = "0";
            }
            else
            {
                int i = Convert.ToInt32((string)cmd.ExecuteScalar());
                int x = i + 1;
                txtRentID.Text = x.ToString();
            }
            conn.Close();
        }

        private void FormPeminjaman_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            
            IsiDataUser();
            txtTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");

            cmd = new SqlCommand("DELETE FROM TBL_RentDetail WHERE RentID=(SELECT RentID FROM TBL_Rent WHERE RentStatus IS NULL); DELETE TBL_Rent WHERE RentStatus IS null", conn);
            cmd.ExecuteNonQuery();

            // ID Peminjaman
            UpdateRentID();

            // RentID
            try
            {
                cmd = new SqlCommand("INSERT INTO TBL_Rent (RentID, UserID) VALUES ('" + txtRentID.Text + "', '" + txtUserID.Text + "')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }

            // Total Pinjam
            cmd = new SqlCommand("SELECT COUNT(RentID) FROM TBL_RentDetail WHERE RentID like '%" + txtRentID.Text + "%'", conn);
            txtTotalPinjam.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
            TampilTabel();

            CekPeminjaman();
        }

        /*
        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            CariTabel();
        }
        */

        // Button Simpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin melakukan peminjaman?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    string strRentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string strRentDueDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                    conn.Open();
                    cmd = new SqlCommand("UPDATE TBL_Rent SET RentStatus=1, RentDate='" + strRentDate + "', RentDueDate='" + strRentDueDate + "', RentLateFee='0' WHERE RentID='" + txtRentID.Text + "'; " +
                        "UPDATE TBL_Buku SET BookStatus = 0 WHERE BookID IN (SELECT BookID FROM TBL_RentDetail WHERE RentID='" + txtRentID.Text + "'); ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    UpdateRentID();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }   
        }

        // Button Input
        private void btnInput_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT COUNT(RentID) FROM TBL_RentDetail WHERE RentID like '%" + txtRentID.Text + "%'", conn);
                if (cmd.ExecuteScalar() != null) txtTotalPinjam.Text = cmd.ExecuteScalar().ToString();
                if ((int)cmd.ExecuteScalar() <= FormLogin.UserInfo.savedUserMaxRent)
                {
                    cmd = new SqlCommand("SELECT BookStatus FROM TBL_Buku WHERE BookID='" + txtBookID.Text + "'", conn);
                    if ((bool)cmd.ExecuteScalar() == true)
                    {
                        cmd = new SqlCommand("INSERT INTO TBL_RentDetail(RentID, BookID) VALUES ('" + txtRentID.Text + "', '" + txtBookID.Text + "')", conn);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("SELECT COUNT(RentID) FROM TBL_RentDetail WHERE RentID like '%" + txtRentID.Text + "%'", conn);
                        if (cmd.ExecuteScalar() != null) txtTotalPinjam.Text = cmd.ExecuteScalar().ToString();
                    }
                    else
                    {
                        MessageBox.Show("Buku tidak tersedia");
                    }
                }
                else
                {
                    MessageBox.Show("Sudah mencapai limit jumlah peminjaman buku");
                }
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
            CekRentDetail();
        }

        // Button Batal
        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin membatalkan peminjaman?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                {
                    cmd = new SqlCommand("DELETE FROM TBL_RentDetail WHERE RentID='" + txtRentID.Text + "'; DELETE FROM TBL_Rent WHERE RentID='%" + txtRentID.Text + "%' ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
            }
        }

        // Button Tutup
        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CekRentDetail();
        }

        private void txtJudul_TextChanged(object sender, EventArgs e)
        {
            CariTabel();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection conn = Konn.GetConn();
                conn.Open();

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtBookID.Text = row.Cells["BookID"].Value.ToString();
                txtJudul.Text = row.Cells["BookTitle"].Value.ToString();
                txtAuthor.Text = row.Cells["BookAuthor"].Value.ToString();
                txtBookType.Text = row.Cells["BookType"].Value.ToString();

                cmd = new SqlCommand("SELECT ShelfLocation FROM TBL_Shelf WHERE ShelfID = '" + row.Cells["ShelfID"].Value.ToString() + "'", conn);
                txtShelf.Text = row.Cells["ShelfID"].Value.ToString() + " - " + (String)cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception X)
            {
                // MessageBox.Show(X.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
