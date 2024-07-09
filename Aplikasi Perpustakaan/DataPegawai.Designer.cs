namespace Aplikasi_Perpustakaan
{
    partial class DataPegawai
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TextPegawai = new TextBox();
            TextNama = new TextBox();
            RadioLaki = new RadioButton();
            RadioPerempuan = new RadioButton();
            TextAlamat = new TextBox();
            TextNo = new TextBox();
            TextTempat = new TextBox();
            Date = new DateTimePicker();
            BtnTambah = new Button();
            BtnSimpan = new Button();
            BtnUbah = new Button();
            BtnBack = new Button();
            Data_Pegawai = new DataGridView();
            Pegawai = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            Jenis = new DataGridViewTextBoxColumn();
            Alamat = new DataGridViewTextBoxColumn();
            No = new DataGridViewTextBoxColumn();
            Tempat = new DataGridViewTextBoxColumn();
            Tanggal = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Pegawai).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1747, 39);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 1;
            label1.Text = "Data Pegawai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Id Pegawai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 2;
            label3.Text = "Nama Pegawai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(12, 133);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(12, 164);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(12, 198);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 5;
            label6.Text = "No Hp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Cornsilk;
            label7.Location = new Point(12, 232);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 6;
            label7.Text = "Tempat Lahir";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Cornsilk;
            label8.Location = new Point(12, 269);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 7;
            label8.Text = "Tanggal Lahir";
            // 
            // TextPegawai
            // 
            TextPegawai.Location = new Point(135, 63);
            TextPegawai.Name = "TextPegawai";
            TextPegawai.Size = new Size(218, 28);
            TextPegawai.TabIndex = 8;
            // 
            // TextNama
            // 
            TextNama.Location = new Point(135, 97);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(218, 28);
            TextNama.TabIndex = 9;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // RadioLaki
            // 
            RadioLaki.AutoSize = true;
            RadioLaki.ForeColor = Color.Cornsilk;
            RadioLaki.Location = new Point(135, 131);
            RadioLaki.Name = "RadioLaki";
            RadioLaki.Size = new Size(100, 24);
            RadioLaki.TabIndex = 10;
            RadioLaki.TabStop = true;
            RadioLaki.Text = "Laki-Laki";
            RadioLaki.UseVisualStyleBackColor = true;
            RadioLaki.KeyPress += RadioLaki_KeyPress;
            // 
            // RadioPerempuan
            // 
            RadioPerempuan.AutoSize = true;
            RadioPerempuan.ForeColor = Color.Cornsilk;
            RadioPerempuan.Location = new Point(241, 131);
            RadioPerempuan.Name = "RadioPerempuan";
            RadioPerempuan.Size = new Size(112, 24);
            RadioPerempuan.TabIndex = 11;
            RadioPerempuan.TabStop = true;
            RadioPerempuan.Text = "Perempuan";
            RadioPerempuan.UseVisualStyleBackColor = true;
            RadioPerempuan.KeyPress += RadioPerempuan_KeyPress;
            // 
            // TextAlamat
            // 
            TextAlamat.Location = new Point(135, 161);
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(218, 28);
            TextAlamat.TabIndex = 12;
            TextAlamat.KeyPress += TextAlamat_KeyPress;
            // 
            // TextNo
            // 
            TextNo.Location = new Point(135, 195);
            TextNo.Name = "TextNo";
            TextNo.Size = new Size(218, 28);
            TextNo.TabIndex = 13;
            TextNo.KeyPress += TextNo_KeyPress;
            // 
            // TextTempat
            // 
            TextTempat.Location = new Point(135, 229);
            TextTempat.Name = "TextTempat";
            TextTempat.Size = new Size(218, 28);
            TextTempat.TabIndex = 14;
            TextTempat.KeyPress += TextTempat_KeyPress;
            // 
            // Date
            // 
            Date.Location = new Point(135, 263);
            Date.Name = "Date";
            Date.Size = new Size(250, 28);
            Date.TabIndex = 15;
            Date.KeyPress += Date_KeyPress;
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(10, 311);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 16;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(123, 311);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 17;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Location = new Point(239, 311);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(94, 29);
            BtnUbah.TabIndex = 18;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(359, 311);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 19;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // Data_Pegawai
            // 
            Data_Pegawai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_Pegawai.Columns.AddRange(new DataGridViewColumn[] { Pegawai, Nama, Jenis, Alamat, No, Tempat, Tanggal, Hapus });
            Data_Pegawai.Location = new Point(12, 383);
            Data_Pegawai.Name = "Data_Pegawai";
            Data_Pegawai.RowHeadersWidth = 51;
            Data_Pegawai.RowTemplate.Height = 29;
            Data_Pegawai.Size = new Size(1725, 660);
            Data_Pegawai.TabIndex = 20;
            Data_Pegawai.CellClick += Data_Pegawai_CellClick;
            // 
            // Pegawai
            // 
            Pegawai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pegawai.HeaderText = "Id Pegawai";
            Pegawai.MinimumWidth = 6;
            Pegawai.Name = "Pegawai";
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Pegawai";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Jenis
            // 
            Jenis.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jenis.HeaderText = "Jenis Kelamin";
            Jenis.MinimumWidth = 6;
            Jenis.Name = "Jenis";
            // 
            // Alamat
            // 
            Alamat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Alamat.HeaderText = "Alamat";
            Alamat.MinimumWidth = 6;
            Alamat.Name = "Alamat";
            // 
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            No.HeaderText = "No Hp";
            No.MinimumWidth = 6;
            No.Name = "No";
            // 
            // Tempat
            // 
            Tempat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tempat.HeaderText = "Tempat Lahir";
            Tempat.MinimumWidth = 6;
            Tempat.Name = "Tempat";
            // 
            // Tanggal
            // 
            Tanggal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tanggal.HeaderText = "Tanggal Lahir";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            // 
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hapus.HeaderText = "";
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Text = "Hapus";
            Hapus.UseColumnTextForButtonValue = true;
            // 
            // DataPegawai
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 127, 255);
            ClientSize = new Size(1749, 1055);
            Controls.Add(Data_Pegawai);
            Controls.Add(BtnBack);
            Controls.Add(BtnUbah);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnTambah);
            Controls.Add(Date);
            Controls.Add(TextTempat);
            Controls.Add(TextNo);
            Controls.Add(TextAlamat);
            Controls.Add(RadioPerempuan);
            Controls.Add(RadioLaki);
            Controls.Add(TextNama);
            Controls.Add(TextPegawai);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataPegawai";
            Text = "DataPegawai";
            FormClosing += DataPegawai_FormClosing;
            Load += DataPegawai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Data_Pegawai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TextPegawai;
        private TextBox TextNama;
        private RadioButton RadioLaki;
        private RadioButton RadioPerempuan;
        private TextBox TextAlamat;
        private TextBox TextNo;
        private TextBox TextTempat;
        private DateTimePicker Date;
        private Button BtnTambah;
        private Button BtnSimpan;
        private Button BtnUbah;
        private Button BtnBack;
        private DataGridView Data_Pegawai;
        private DataGridViewTextBoxColumn Pegawai;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Jenis;
        private DataGridViewTextBoxColumn Alamat;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Tempat;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewButtonColumn Hapus;
    }
}