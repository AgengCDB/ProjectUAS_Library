namespace ProjectUAS
{
    partial class FormPeminjaman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTanggal = new System.Windows.Forms.TextBox();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtShelf = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalBuku = new System.Windows.Forms.TextBox();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtTotalPinjam = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(601, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peminjaman Buku";
            // 
            // txtTanggal
            // 
            this.txtTanggal.Enabled = false;
            this.txtTanggal.Location = new System.Drawing.Point(1058, 74);
            this.txtTanggal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(222, 31);
            this.txtTanggal.TabIndex = 9;
            // 
            // txtRentID
            // 
            this.txtRentID.Enabled = false;
            this.txtRentID.Location = new System.Drawing.Point(1058, 110);
            this.txtRentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(223, 31);
            this.txtRentID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Peminjaman";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 369);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(976, 225);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(425, 76);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(410, 31);
            this.txtUserID.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(425, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(410, 31);
            this.txtName.TabIndex = 13;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(425, 150);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(856, 31);
            this.txtAlamat.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Alamat";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Enabled = false;
            this.txtTelepon.Location = new System.Drawing.Point(425, 188);
            this.txtTelepon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(410, 31);
            this.txtTelepon.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telepon";
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(425, 251);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(193, 31);
            this.txtBookID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Book ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(750, 258);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Judul";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(870, 254);
            this.txtJudul.Margin = new System.Windows.Forms.Padding(2);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(410, 31);
            this.txtJudul.TabIndex = 22;
            this.txtJudul.TextChanged += new System.EventHandler(this.txtJudul_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(870, 291);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(410, 31);
            this.txtAuthor.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(750, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Pengarang";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 291);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tipe Buku";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBookType
            // 
            this.txtBookType.Enabled = false;
            this.txtBookType.Location = new System.Drawing.Point(425, 289);
            this.txtBookType.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.Size = new System.Drawing.Size(193, 31);
            this.txtBookType.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 329);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Lokasi Rak";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtShelf
            // 
            this.txtShelf.Enabled = false;
            this.txtShelf.Location = new System.Drawing.Point(425, 325);
            this.txtShelf.Margin = new System.Windows.Forms.Padding(2);
            this.txtShelf.Name = "txtShelf";
            this.txtShelf.Size = new System.Drawing.Size(193, 31);
            this.txtShelf.TabIndex = 28;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(870, 329);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(116, 34);
            this.btnInput.TabIndex = 29;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(932, 605);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Total Buku";
            // 
            // txtTotalBuku
            // 
            this.txtTotalBuku.Enabled = false;
            this.txtTotalBuku.Location = new System.Drawing.Point(1050, 602);
            this.txtTotalBuku.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalBuku.Name = "txtTotalBuku";
            this.txtTotalBuku.Size = new System.Drawing.Size(229, 31);
            this.txtTotalBuku.TabIndex = 31;
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(1169, 639);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(2);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(112, 34);
            this.btnTutup.TabIndex = 32;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(1050, 639);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(112, 34);
            this.btnBatal.TabIndex = 33;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(932, 639);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(112, 34);
            this.btnSimpan.TabIndex = 34;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(304, 679);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(976, 242);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtTotalPinjam
            // 
            this.txtTotalPinjam.Enabled = false;
            this.txtTotalPinjam.Location = new System.Drawing.Point(452, 928);
            this.txtTotalPinjam.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPinjam.Name = "txtTotalPinjam";
            this.txtTotalPinjam.Size = new System.Drawing.Size(266, 31);
            this.txtTotalPinjam.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(304, 930);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 25);
            this.label14.TabIndex = 37;
            this.label14.Text = "Total Pinjam";
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 969);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotalPinjam);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.txtTotalBuku);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtShelf);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBookType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.txtRentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPeminjaman";
            this.Text = "Form Peminjaman Buku";
            this.Load += new System.EventHandler(this.FormPeminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTanggal;
        private TextBox txtRentID;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox txtUserID;
        private TextBox txtName;
        private TextBox txtAlamat;
        private Label label5;
        private Label label6;
        private TextBox txtTelepon;
        private Label label7;
        private TextBox txtBookID;
        private Label label8;
        private Label label9;
        private TextBox txtJudul;
        private TextBox txtAuthor;
        private Label label10;
        private Label label11;
        private TextBox txtBookType;
        private Label label12;
        private TextBox txtShelf;
        private Button btnInput;
        private Label label13;
        private TextBox txtTotalBuku;
        private Button btnTutup;
        private Button btnBatal;
        private Button btnSimpan;
        private DataGridView dataGridView2;
        private TextBox txtTotalPinjam;
        private Label label14;
    }
}