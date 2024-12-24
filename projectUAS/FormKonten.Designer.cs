
namespace projectUAS
{
    partial class FormKonten
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
            this.pnlKonten = new System.Windows.Forms.Panel();
            this.dtgKonten = new System.Windows.Forms.DataGridView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cbxNamaOrg = new System.Windows.Forms.ComboBox();
            this.lblOrg = new System.Windows.Forms.Label();
            this.cbxTingkat = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlKonten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKonten)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKonten
            // 
            this.pnlKonten.BackColor = System.Drawing.Color.LightGray;
            this.pnlKonten.Controls.Add(this.dtgKonten);
            this.pnlKonten.Controls.Add(this.btnTutup);
            this.pnlKonten.Controls.Add(this.btnTambah);
            this.pnlKonten.Controls.Add(this.cbxNamaOrg);
            this.pnlKonten.Controls.Add(this.lblOrg);
            this.pnlKonten.Controls.Add(this.cbxTingkat);
            this.pnlKonten.Location = new System.Drawing.Point(17, 48);
            this.pnlKonten.Margin = new System.Windows.Forms.Padding(10);
            this.pnlKonten.Name = "pnlKonten";
            this.pnlKonten.Size = new System.Drawing.Size(725, 673);
            this.pnlKonten.TabIndex = 10;
            // 
            // dtgKonten
            // 
            this.dtgKonten.BackgroundColor = System.Drawing.Color.White;
            this.dtgKonten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKonten.Location = new System.Drawing.Point(19, 63);
            this.dtgKonten.Margin = new System.Windows.Forms.Padding(10);
            this.dtgKonten.Name = "dtgKonten";
            this.dtgKonten.RowHeadersWidth = 51;
            this.dtgKonten.RowTemplate.Height = 24;
            this.dtgKonten.Size = new System.Drawing.Size(691, 507);
            this.dtgKonten.TabIndex = 18;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTutup.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(584, 609);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(126, 49);
            this.btnTutup.TabIndex = 17;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTambah.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(15, 609);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(15);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(154, 49);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // cbxNamaOrg
            // 
            this.cbxNamaOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNamaOrg.FormattingEnabled = true;
            this.cbxNamaOrg.Location = new System.Drawing.Point(438, 10);
            this.cbxNamaOrg.Margin = new System.Windows.Forms.Padding(10);
            this.cbxNamaOrg.Name = "cbxNamaOrg";
            this.cbxNamaOrg.Size = new System.Drawing.Size(272, 33);
            this.cbxNamaOrg.TabIndex = 16;
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrg.Location = new System.Drawing.Point(10, 12);
            this.lblOrg.Margin = new System.Windows.Forms.Padding(10);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(119, 24);
            this.lblOrg.TabIndex = 15;
            this.lblOrg.Text = "Organisasi:";
            // 
            // cbxTingkat
            // 
            this.cbxTingkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTingkat.FormattingEnabled = true;
            this.cbxTingkat.Location = new System.Drawing.Point(146, 10);
            this.cbxTingkat.Margin = new System.Windows.Forms.Padding(10);
            this.cbxTingkat.Name = "cbxTingkat";
            this.cbxTingkat.Size = new System.Drawing.Size(272, 33);
            this.cbxTingkat.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Items.AddRange(new object[] {
            "Setiap user pada aplikasi ini dapat membuat konten berupa tulisan, gambar,",
            "video, dan kombinasinya. Sistem membatasi pada 1 konten hanya terdapat 1",
            "tulisan, 1 gambar dan/atau 1 video.",
            "Pada konten yang dibuat, ia dapat melakukan tag pada user lain yang telah",
            "menjadi teman",
            "Data grid konten + button row check komen",
            "!belum selesai!"});
            this.listBox1.Location = new System.Drawing.Point(767, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1093, 544);
            this.listBox1.TabIndex = 8;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(102, 32);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Konten";
            // 
            // FormKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1905, 751);
            this.Controls.Add(this.pnlKonten);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormKonten";
            this.Text = "FormPost";
            this.pnlKonten.ResumeLayout(false);
            this.pnlKonten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKonten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlKonten;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cbxNamaOrg;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.ComboBox cbxTingkat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.DataGridView dtgKonten;
    }
}