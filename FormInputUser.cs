using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectUAS
{
    public partial class FormInputUser : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();
        public FormInputUser()
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
            textBox6.Text = "";
        }

        void CariTable()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_User where UserID like '%" + textBox7.Text + "%' or UserName like '%" + textBox7.Text + "%'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_User");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_User";
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
                cmd = new SqlCommand("Select * From TBL_User", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_User");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_User";
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
                    cmd = new SqlCommand("INSERT INTO TBL_User VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("UPDATE TBL_User SET UserTypeID = '" + textBox2.Text + "', Username ='" + textBox3.Text + "', UserAddress ='" + textBox4.Text + "', UserPhone ='" + textBox5.Text + "', UserPassword ='" + textBox6.Text + "' WHERE UserID = '" + textBox1.Text + "'", conn);
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
            if (MessageBox.Show("Yaking akan menghapus data User : " + textBox1.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                {
                    cmd = new SqlCommand("DELETE TBL_User WHERE UserID = '" + textBox1.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data Berhasil");
                    TampilTabel();
                    Bersihkan();
                }
            }
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
                textBox1.Text = row.Cells["UserID"].Value.ToString(); 
                textBox2.Text = row.Cells["UserTypeID"].Value.ToString();
                textBox3.Text = row.Cells["UserName"].Value.ToString();
                textBox4.Text = row.Cells["UserAddress"].Value.ToString();
                textBox5.Text = row.Cells["UserPhone"].Value.ToString();
                textBox6.Text = row.Cells["UserPassword"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void FormInputUser_Load(object sender, EventArgs e)
        {
            TampilTabel();
        }
    }
}
