
namespace projectUAS
{
    partial class FormDaftarOrganisasi
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
            this.pnlDOrg = new System.Windows.Forms.Panel();
            this.txtOrganisasi = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dtgOrg = new System.Windows.Forms.DataGridView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.lblTingkat = new System.Windows.Forms.Label();
            this.cbxTingkat = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlDOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDOrg
            // 
            this.pnlDOrg.BackColor = System.Drawing.Color.LightGray;
            this.pnlDOrg.Controls.Add(this.txtOrganisasi);
            this.pnlDOrg.Controls.Add(this.btnTambah);
            this.pnlDOrg.Controls.Add(this.dtgOrg);
            this.pnlDOrg.Controls.Add(this.btnTutup);
            this.pnlDOrg.Controls.Add(this.lblTingkat);
            this.pnlDOrg.Controls.Add(this.cbxTingkat);
            this.pnlDOrg.Location = new System.Drawing.Point(17, 48);
            this.pnlDOrg.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDOrg.Name = "pnlDOrg";
            this.pnlDOrg.Size = new System.Drawing.Size(725, 673);
            this.pnlDOrg.TabIndex = 6;
            // 
            // txtOrganisasi
            // 
            this.txtOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganisasi.Location = new System.Drawing.Point(434, 10);
            this.txtOrganisasi.Margin = new System.Windows.Forms.Padding(10);
            this.txtOrganisasi.Name = "txtOrganisasi";
            this.txtOrganisasi.Size = new System.Drawing.Size(272, 34);
            this.txtOrganisasi.TabIndex = 19;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTambah.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(15, 615);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(15);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(145, 43);
            this.btnTambah.TabIndex = 18;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dtgOrg
            // 
            this.dtgOrg.BackgroundColor = System.Drawing.Color.White;
            this.dtgOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrg.Location = new System.Drawing.Point(15, 63);
            this.dtgOrg.Margin = new System.Windows.Forms.Padding(10);
            this.dtgOrg.Name = "dtgOrg";
            this.dtgOrg.RowHeadersWidth = 51;
            this.dtgOrg.RowTemplate.Height = 24;
            this.dtgOrg.Size = new System.Drawing.Size(691, 507);
            this.dtgOrg.TabIndex = 17;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTutup.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(580, 615);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(126, 43);
            this.btnTutup.TabIndex = 3;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // lblTingkat
            // 
            this.lblTingkat.AutoSize = true;
            this.lblTingkat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTingkat.Location = new System.Drawing.Point(10, 13);
            this.lblTingkat.Margin = new System.Windows.Forms.Padding(10);
            this.lblTingkat.Name = "lblTingkat";
            this.lblTingkat.Size = new System.Drawing.Size(88, 24);
            this.lblTingkat.TabIndex = 15;
            this.lblTingkat.Text = "Tingkat:";
            // 
            // cbxTingkat
            // 
            this.cbxTingkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTingkat.FormattingEnabled = true;
            this.cbxTingkat.Location = new System.Drawing.Point(142, 10);
            this.cbxTingkat.Margin = new System.Windows.Forms.Padding(10);
            this.cbxTingkat.Name = "cbxTingkat";
            this.cbxTingkat.Size = new System.Drawing.Size(272, 33);
            this.cbxTingkat.TabIndex = 13;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(233, 32);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Daftar Organisasi";
            // 
            // FormDaftarOrganisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(762, 736);
            this.Controls.Add(this.pnlDOrg);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormDaftarOrganisasi";
            this.Text = "FormDaftarOrganisasi";
            this.pnlDOrg.ResumeLayout(false);
            this.pnlDOrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDOrg;
        private System.Windows.Forms.DataGridView dtgOrg;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label lblTingkat;
        private System.Windows.Forms.ComboBox cbxTingkat;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtOrganisasi;
    }
}