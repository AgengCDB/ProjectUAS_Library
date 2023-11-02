using System.Data;
using System.Data.SqlClient;

namespace ProjectUAS
{
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        
        Koneksi Konn = new Koneksi();
       
        public static class UserInfo
        {
            public static string savedUserID = "";
            public static string savedUserType = "";
            public static string savedUserName = "";
            public static string savedUserAddress = "";
            public static string savedUserPhone = "";
            public static int savedUserMaxRent = 0;
        }

        void InputUserInfo()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();

            // UID
            UserInfo.savedUserID = textBox1.Text;
            
            // UType
            cmd = new SqlCommand("SELECT UserTypeID FROM TBL_User WHERE UserID='" + textBox1.Text + "' and UserPassword='" + textBox2.Text + "'", conn);
            UserInfo.savedUserType = (String)cmd.ExecuteScalar();

            // UName
            cmd = new SqlCommand("SELECT UserName FROM TBL_User WHERE UserID='" + textBox1.Text + "' and UserPassword='" + textBox2.Text + "'", conn);
            UserInfo.savedUserName = (String)cmd.ExecuteScalar();

            // UAddress
            cmd = new SqlCommand("SELECT UserAddress FROM TBL_User WHERE UserID='" + textBox1.Text + "' and UserPassword='" + textBox2.Text + "'", conn);
            UserInfo.savedUserAddress = (String)cmd.ExecuteScalar();

            // UPhone
            cmd = new SqlCommand("SELECT UserPhone FROM TBL_User WHERE UserID='" + textBox1.Text + "' and UserPassword='" + textBox2.Text + "'", conn);
            UserInfo.savedUserPhone = (String)cmd.ExecuteScalar();

            // UMaxPinjam
            if (UserInfo.savedUserType == null)
            {
                UserInfo.savedUserMaxRent = 0;
            }
            else if (UserInfo.savedUserType == "1")
            {
                UserInfo.savedUserMaxRent = 20;
            }
            else if (UserInfo.savedUserType == "2")
            {
                UserInfo.savedUserMaxRent = 10;
            }
            else if (UserInfo.savedUserType == "3")
            {
                UserInfo.savedUserMaxRent= 5;
            }
            conn.Close();
        }
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from TBL_User where UserID='" + textBox1.Text + "' and UserPassword='" + textBox2.Text + "'", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                InputUserInfo();
                FormMenu frmUtama = new FormMenu();
                frmUtama.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("ID atau Password Salah!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            // var checkBox = (CheckBox)sender;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                
               
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                
            }
        }
    }
}