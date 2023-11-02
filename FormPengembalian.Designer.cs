
namespace ProjectUAS
{
    partial class FormPengembalian
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDateToday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTampilkanPeminjaman = new System.Windows.Forms.Button();
            this.btnKembalikan = new System.Windows.Forms.Button();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRentDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRentDueDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRentLateFee = new System.Windows.Forms.TextBox();
            this.btnTampilkanBuku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(594, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pengembalian Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Daftar Peminjaman";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 159);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(976, 212);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDateToday
            // 
            this.txtDateToday.Enabled = false;
            this.txtDateToday.Location = new System.Drawing.Point(1072, 106);
            this.txtDateToday.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateToday.Name = "txtDateToday";
            this.txtDateToday.Size = new System.Drawing.Size(192, 31);
            this.txtDateToday.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(969, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tanggal";
            // 
            // btnTampilkanPeminjaman
            // 
            this.btnTampilkanPeminjaman.Location = new System.Drawing.Point(288, 518);
            this.btnTampilkanPeminjaman.Margin = new System.Windows.Forms.Padding(2);
            this.btnTampilkanPeminjaman.Name = "btnTampilkanPeminjaman";
            this.btnTampilkanPeminjaman.Size = new System.Drawing.Size(224, 34);
            this.btnTampilkanPeminjaman.TabIndex = 8;
            this.btnTampilkanPeminjaman.Text = "Tampilkan Peminjaman";
            this.btnTampilkanPeminjaman.UseVisualStyleBackColor = true;
            this.btnTampilkanPeminjaman.Click += new System.EventHandler(this.btnTampilkanPeminjaman_Click);
            // 
            // btnKembalikan
            // 
            this.btnKembalikan.Location = new System.Drawing.Point(1002, 518);
            this.btnKembalikan.Margin = new System.Windows.Forms.Padding(2);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.Size = new System.Drawing.Size(260, 34);
            this.btnKembalikan.TabIndex = 9;
            this.btnKembalikan.Text = "Kembalikan Buku";
            this.btnKembalikan.UseVisualStyleBackColor = true;
            this.btnKembalikan.Click += new System.EventHandler(this.btnKembalikan_Click);
            // 
            // txtRentID
            // 
            this.txtRentID.Enabled = false;
            this.txtRentID.Location = new System.Drawing.Point(501, 404);
            this.txtRentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(229, 31);
            this.txtRentID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "RentID";
            // 
            // txtRentDate
            // 
            this.txtRentDate.Enabled = false;
            this.txtRentDate.Location = new System.Drawing.Point(501, 441);
            this.txtRentDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentDate.Name = "txtRentDate";
            this.txtRentDate.Size = new System.Drawing.Size(229, 31);
            this.txtRentDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tanggal Peminjaman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 481);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Batas Pengembalian";
            // 
            // txtRentDueDate
            // 
            this.txtRentDueDate.Enabled = false;
            this.txtRentDueDate.Location = new System.Drawing.Point(501, 478);
            this.txtRentDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentDueDate.Name = "txtRentDueDate";
            this.txtRentDueDate.Size = new System.Drawing.Size(229, 31);
            this.txtRentDueDate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(942, 408);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Denda";
            // 
            // txtRentLateFee
            // 
            this.txtRentLateFee.Enabled = false;
            this.txtRentLateFee.Location = new System.Drawing.Point(1035, 404);
            this.txtRentLateFee.Margin = new System.Windows.Forms.Padding(2);
            this.txtRentLateFee.Name = "txtRentLateFee";
            this.txtRentLateFee.Size = new System.Drawing.Size(228, 31);
            this.txtRentLateFee.TabIndex = 17;
            // 
            // btnTampilkanBuku
            // 
            this.btnTampilkanBuku.Location = new System.Drawing.Point(518, 518);
            this.btnTampilkanBuku.Margin = new System.Windows.Forms.Padding(2);
            this.btnTampilkanBuku.Name = "btnTampilkanBuku";
            this.btnTampilkanBuku.Size = new System.Drawing.Size(198, 34);
            this.btnTampilkanBuku.TabIndex = 18;
            this.btnTampilkanBuku.Text = "Tampilkan Buku";
            this.btnTampilkanBuku.UseVisualStyleBackColor = true;
            this.btnTampilkanBuku.Click += new System.EventHandler(this.btnTampilkanBuku_Click);
            // 
            // FormPengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 655);
            this.Controls.Add(this.btnTampilkanBuku);
            this.Controls.Add(this.txtRentLateFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRentDueDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRentDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRentID);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.btnTampilkanPeminjaman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDateToday);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPengembalian";
            this.Text = "Form Peminjaman Buku";
            this.Load += new System.EventHandler(this.FormPengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtDateToday;
        private Label label3;
        private Button btnTampilkanPeminjaman;
        private Button btnKembalikan;
        private TextBox txtRentID;
        private Label label4;
        private TextBox txtRentDate;
        private Label label5;
        private Label label6;
        private TextBox txtRentDueDate;
        private Label label7;
        private TextBox txtRentLateFee;
        private Button btnTampilkanBuku;
    }
}

