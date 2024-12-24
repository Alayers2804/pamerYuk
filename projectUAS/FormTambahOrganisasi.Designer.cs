
namespace projectUAS
{
    partial class FormTambahOrganisasi
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
            this.lblKota = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlTOrg = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnTutup = new System.Windows.Forms.Button();
            this.cbxKota = new System.Windows.Forms.ComboBox();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlTOrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKota.Location = new System.Drawing.Point(57, 13);
            this.lblKota.Margin = new System.Windows.Forms.Padding(10);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(61, 24);
            this.lblKota.TabIndex = 8;
            this.lblKota.Text = "Kota:";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(136, 117);
            this.txtNama.Margin = new System.Windows.Forms.Padding(10);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(272, 34);
            this.txtNama.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(46, 123);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(10);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 24);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Nama:";
            // 
            // pnlTOrg
            // 
            this.pnlTOrg.BackColor = System.Drawing.Color.LightGray;
            this.pnlTOrg.Controls.Add(this.txtID);
            this.pnlTOrg.Controls.Add(this.lblID);
            this.pnlTOrg.Controls.Add(this.btnTutup);
            this.pnlTOrg.Controls.Add(this.cbxKota);
            this.pnlTOrg.Controls.Add(this.btnDaftar);
            this.pnlTOrg.Controls.Add(this.lblKota);
            this.pnlTOrg.Controls.Add(this.txtNama);
            this.pnlTOrg.Controls.Add(this.lblPassword);
            this.pnlTOrg.Location = new System.Drawing.Point(19, 48);
            this.pnlTOrg.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTOrg.Name = "pnlTOrg";
            this.pnlTOrg.Size = new System.Drawing.Size(424, 223);
            this.pnlTOrg.TabIndex = 15;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(136, 63);
            this.txtID.Margin = new System.Windows.Forms.Padding(10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(272, 34);
            this.txtID.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(79, 69);
            this.lblID.Margin = new System.Windows.Forms.Padding(10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 24);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID:";
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTutup.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(282, 165);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(126, 45);
            this.btnTutup.TabIndex = 18;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // cbxKota
            // 
            this.cbxKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKota.FormattingEnabled = true;
            this.cbxKota.Location = new System.Drawing.Point(136, 10);
            this.cbxKota.Margin = new System.Windows.Forms.Padding(10);
            this.cbxKota.Name = "cbxKota";
            this.cbxKota.Size = new System.Drawing.Size(272, 33);
            this.cbxKota.TabIndex = 16;
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDaftar.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(15, 165);
            this.btnDaftar.Margin = new System.Windows.Forms.Padding(15);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(126, 45);
            this.btnDaftar.TabIndex = 15;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(255, 32);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Tambah Organisasi";
            // 
            // FormTambahOrganisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(457, 290);
            this.Controls.Add(this.pnlTOrg);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormTambahOrganisasi";
            this.Text = "FormTambahOrganisasi";
            this.pnlTOrg.ResumeLayout(false);
            this.pnlTOrg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlTOrg;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbxKota;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}