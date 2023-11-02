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
    public partial class FormDaftarBuku : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

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
        public FormDaftarBuku()
        {
            InitializeComponent();
        }
        void CariTable()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_Buku where BookID like '%" + textBox1.Text + "%' or BookTitle like '%" + textBox1.Text + "%' or BookAuthor like '%" + textBox1.Text + "%'", conn);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CariTable();
        }

        private void FormDaftarBuku_Load(object sender, EventArgs e)
        {
            TampilTabel();
        }

        private void FormDaftarBuku_Load_1(object sender, EventArgs e)
        {
            TampilTabel();
        }
    }
}
