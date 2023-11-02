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
    public partial class FormInputBuku : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public FormInputBuku()
        {
            InitializeComponent();
        }

        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "0";
            textBox1.Text = "0";
        }

        void CariTable()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_Buku where BookID like '%" + textBox7.Text + "%' or BookTitle like '%" + textBox7.Text + "%'", conn);
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

        void TampilTabel()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * From TBL_Buku", conn);
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

        void NoOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select BookID from TBL_Buku where BookID in(select max(BookID) from TBL_Buku) order by BookID desc", conn);
            if ((String)cmd.ExecuteScalar() != null)
            {
                urutan = (Convert.ToInt64((String)cmd.ExecuteScalar()) + 1).ToString();
            }
            else
            {
                urutan = "1";
            }
            textBox2.Enabled = false;
            textBox2.Text = urutan;
            conn.Close();
        }

        // button InputBuku
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO TBL_Buku VALUES ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '1')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    // cmd = new SqlCommand("INSERT INTO TBL_InsertBook VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')", conn);
                    MessageBox.Show("Insert Data Berhasil");
                    // cmd.ExecuteNonQuery();
                    Bersihkan();
                    TampilTabel();
                    conn.Close();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void FormInputBuku_Load(object sender, EventArgs e)
        {
            textBox1.Text = FormLogin.UserInfo.savedUserID.ToString();
            TampilTabel();
            NoOtomatis();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CariTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["BookID"].Value.ToString();
                textBox3.Text = row.Cells["BookTitle"].Value.ToString();
                textBox4.Text = row.Cells["BookAuthor"].Value.ToString();
                textBox5.Text = row.Cells["BookType"].Value.ToString();
                textBox6.Text = row.Cells["ShelfID"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("UPDATE TBL_Buku SET BookTitle = '" + textBox3.Text + "', BookAuthor ='" + textBox4.Text + "', BookType ='" + textBox5.Text + "', ShelfID ='" + textBox6.Text + "' WHERE BookID = '" + textBox2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Berhasil");
                    TampilTabel();
                    Bersihkan();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yaking akan menghapus data Buku : " + textBox2.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                {
                    cmd = new SqlCommand("DELETE TBL_Buku WHERE BookID = '" + textBox2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data Berhasil");
                    TampilTabel();
                    Bersihkan();
                }
            }
        }

       
    }
}
