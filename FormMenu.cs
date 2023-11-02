using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProjectUAS
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new FormStaff());
            
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            if (FormLogin.UserInfo.savedUserType.ToString() != "1")
            {
                button1.Hide();
                button1.Visible = false;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new FormDaftarBuku());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new FormPeminjaman());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new FormPengembalian());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Hide();
        }

       
    }
}
