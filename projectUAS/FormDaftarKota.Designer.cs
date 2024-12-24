
namespace projectUAS
{
    partial class FormDaftarKota
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
            this.txtKota = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dtgKota = new System.Windows.Forms.DataGridView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.lblTingkat = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlDOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKota)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDOrg
            // 
            this.pnlDOrg.BackColor = System.Drawing.Color.LightGray;
            this.pnlDOrg.Controls.Add(this.txtKota);
            this.pnlDOrg.Controls.Add(this.btnTambah);
            this.pnlDOrg.Controls.Add(this.dtgKota);
            this.pnlDOrg.Controls.Add(this.btnTutup);
            this.pnlDOrg.Controls.Add(this.lblTingkat);
            this.pnlDOrg.Location = new System.Drawing.Point(17, 48);
            this.pnlDOrg.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDOrg.Name = "pnlDOrg";
            this.pnlDOrg.Size = new System.Drawing.Size(725, 673);
            this.pnlDOrg.TabIndex = 8;
            // 
            // txtKota
            // 
            this.txtKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKota.Location = new System.Drawing.Point(434, 10);
            this.txtKota.Margin = new System.Windows.Forms.Padding(10);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(272, 34);
            this.txtKota.TabIndex = 19;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTambah.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(15, 614);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(15);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(162, 44);
            this.btnTambah.TabIndex = 18;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dtgKota
            // 
            this.dtgKota.BackgroundColor = System.Drawing.Color.White;
            this.dtgKota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKota.Location = new System.Drawing.Point(15, 63);
            this.dtgKota.Margin = new System.Windows.Forms.Padding(10);
            this.dtgKota.Name = "dtgKota";
            this.dtgKota.RowHeadersWidth = 51;
            this.dtgKota.RowTemplate.Height = 24;
            this.dtgKota.Size = new System.Drawing.Size(691, 507);
            this.dtgKota.TabIndex = 17;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTutup.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(580, 614);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(126, 44);
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
            this.lblTingkat.Size = new System.Drawing.Size(61, 24);
            this.lblTingkat.TabIndex = 15;
            this.lblTingkat.Text = "Kota:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(157, 32);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "Daftar Kota";
            // 
            // FormDaftarKota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(759, 737);
            this.Controls.Add(this.pnlDOrg);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormDaftarKota";
            this.Text = "FormDaftarKota";
            this.pnlDOrg.ResumeLayout(false);
            this.pnlDOrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDOrg;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dtgKota;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label lblTingkat;
        private System.Windows.Forms.Label lblHeader;
    }
}