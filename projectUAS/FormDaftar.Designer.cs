
namespace projectUAS
{
    partial class FormDaftar
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlPendaftaran = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.dtpbirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKota = new System.Windows.Forms.Label();
            this.cbxKota = new System.Windows.Forms.ComboBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtKTP = new System.Windows.Forms.TextBox();
            this.lblKTP = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblOrg = new System.Windows.Forms.Label();
            this.cbxTingkat = new System.Windows.Forms.ComboBox();
            this.txtThnAwl = new System.Windows.Forms.TextBox();
            this.txtThnAkr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.pnlPendaftaran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(14, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(164, 32);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Pendaftaran";
            // 
            // pnlPendaftaran
            // 
            this.pnlPendaftaran.BackColor = System.Drawing.Color.LightGray;
            this.pnlPendaftaran.Controls.Add(this.txtDeskripsi);
            this.pnlPendaftaran.Controls.Add(this.label4);
            this.pnlPendaftaran.Controls.Add(this.pictureBox1);
            this.pnlPendaftaran.Controls.Add(this.label3);
            this.pnlPendaftaran.Controls.Add(this.label2);
            this.pnlPendaftaran.Controls.Add(this.txtThnAkr);
            this.pnlPendaftaran.Controls.Add(this.txtThnAwl);
            this.pnlPendaftaran.Controls.Add(this.lblOrg);
            this.pnlPendaftaran.Controls.Add(this.cbxTingkat);
            this.pnlPendaftaran.Controls.Add(this.button1);
            this.pnlPendaftaran.Controls.Add(this.btnDaftar);
            this.pnlPendaftaran.Controls.Add(this.dtpbirthDate);
            this.pnlPendaftaran.Controls.Add(this.label1);
            this.pnlPendaftaran.Controls.Add(this.lblKota);
            this.pnlPendaftaran.Controls.Add(this.cbxKota);
            this.pnlPendaftaran.Controls.Add(this.lblFoto);
            this.pnlPendaftaran.Controls.Add(this.txtPassword);
            this.pnlPendaftaran.Controls.Add(this.lblPassword);
            this.pnlPendaftaran.Controls.Add(this.txtUsername);
            this.pnlPendaftaran.Controls.Add(this.lblUsername);
            this.pnlPendaftaran.Controls.Add(this.txtKTP);
            this.pnlPendaftaran.Controls.Add(this.lblKTP);
            this.pnlPendaftaran.Controls.Add(this.txtNama);
            this.pnlPendaftaran.Controls.Add(this.lblNama);
            this.pnlPendaftaran.Location = new System.Drawing.Point(19, 48);
            this.pnlPendaftaran.Margin = new System.Windows.Forms.Padding(10);
            this.pnlPendaftaran.Name = "pnlPendaftaran";
            this.pnlPendaftaran.Size = new System.Drawing.Size(1245, 673);
            this.pnlPendaftaran.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(188, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tutup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Tutup);
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDaftar.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(464, 473);
            this.btnDaftar.Margin = new System.Windows.Forms.Padding(15);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(126, 44);
            this.btnDaftar.TabIndex = 3;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // dtpbirthDate
            // 
            this.dtpbirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbirthDate.Location = new System.Drawing.Point(186, 234);
            this.dtpbirthDate.Margin = new System.Windows.Forms.Padding(10);
            this.dtpbirthDate.Name = "dtpbirthDate";
            this.dtpbirthDate.Size = new System.Drawing.Size(402, 34);
            this.dtpbirthDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tanggal Lahir:";
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKota.Location = new System.Drawing.Point(107, 345);
            this.lblKota.Margin = new System.Windows.Forms.Padding(10);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(61, 24);
            this.lblKota.TabIndex = 14;
            this.lblKota.Text = "Kota:";
            // 
            // cbxKota
            // 
            this.cbxKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKota.FormattingEnabled = true;
            this.cbxKota.Location = new System.Drawing.Point(186, 342);
            this.cbxKota.Margin = new System.Windows.Forms.Padding(10);
            this.cbxKota.Name = "cbxKota";
            this.cbxKota.Size = new System.Drawing.Size(402, 33);
            this.cbxKota.TabIndex = 12;
            this.cbxKota.SelectedIndexChanged += new System.EventHandler(this.cbxKota_SelectedIndexChanged);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(111, 294);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(10);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(60, 24);
            this.lblFoto.TabIndex = 8;
            this.lblFoto.Text = "Foto:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(189, 78);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(402, 34);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(65, 84);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(10);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(110, 24);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(188, 28);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(403, 34);
            this.txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(60, 34);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(112, 24);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // txtKTP
            // 
            this.txtKTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKTP.Location = new System.Drawing.Point(188, 129);
            this.txtKTP.Margin = new System.Windows.Forms.Padding(10);
            this.txtKTP.Name = "txtKTP";
            this.txtKTP.Size = new System.Drawing.Size(402, 34);
            this.txtKTP.TabIndex = 3;
            // 
            // lblKTP
            // 
            this.lblKTP.AutoSize = true;
            this.lblKTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKTP.Location = new System.Drawing.Point(75, 135);
            this.lblKTP.Margin = new System.Windows.Forms.Padding(10);
            this.lblKTP.Name = "lblKTP";
            this.lblKTP.Size = new System.Drawing.Size(95, 24);
            this.lblKTP.TabIndex = 2;
            this.lblKTP.Text = "No. KTP:";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(188, 180);
            this.txtNama.Margin = new System.Windows.Forms.Padding(10);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(402, 34);
            this.txtNama.TabIndex = 1;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(17, 186);
            this.lblNama.Margin = new System.Windows.Forms.Padding(10);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(157, 24);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Lengkap:";
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrg.Location = new System.Drawing.Point(667, 28);
            this.lblOrg.Margin = new System.Windows.Forms.Padding(10);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(119, 24);
            this.lblOrg.TabIndex = 23;
            this.lblOrg.Text = "Organisasi:";
            // 
            // cbxTingkat
            // 
            this.cbxTingkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTingkat.FormattingEnabled = true;
            this.cbxTingkat.Location = new System.Drawing.Point(806, 24);
            this.cbxTingkat.Margin = new System.Windows.Forms.Padding(10);
            this.cbxTingkat.Name = "cbxTingkat";
            this.cbxTingkat.Size = new System.Drawing.Size(384, 33);
            this.cbxTingkat.TabIndex = 22;
            this.cbxTingkat.SelectedIndexChanged += new System.EventHandler(this.cbxTingkat_SelectedIndexChanged);
            // 
            // txtThnAwl
            // 
            this.txtThnAwl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThnAwl.Location = new System.Drawing.Point(806, 234);
            this.txtThnAwl.Margin = new System.Windows.Forms.Padding(10);
            this.txtThnAwl.Name = "txtThnAwl";
            this.txtThnAwl.Size = new System.Drawing.Size(138, 34);
            this.txtThnAwl.TabIndex = 24;
            // 
            // txtThnAkr
            // 
            this.txtThnAkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThnAkr.Location = new System.Drawing.Point(1052, 234);
            this.txtThnAkr.Margin = new System.Windows.Forms.Padding(10);
            this.txtThnAkr.Name = "txtThnAkr";
            this.txtThnAkr.Size = new System.Drawing.Size(138, 34);
            this.txtThnAkr.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(725, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Dari :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(952, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sampai :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(189, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(681, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Deskripsi:";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(806, 81);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(384, 133);
            this.txtDeskripsi.TabIndex = 30;
            // 
            // FormDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.pnlPendaftaran);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormDaftar";
            this.Text = "FormDaftar";
            this.pnlPendaftaran.ResumeLayout(false);
            this.pnlPendaftaran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlPendaftaran;
        private System.Windows.Forms.TextBox txtKTP;
        private System.Windows.Forms.Label lblKTP;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.DateTimePicker dtpbirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.ComboBox cbxKota;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.ComboBox cbxTingkat;
        private System.Windows.Forms.TextBox txtThnAwl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThnAkr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeskripsi;
    }
}