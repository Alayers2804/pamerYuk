
namespace projectUAS
{
    partial class FormSearch
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
            this.pnlPendaftaran = new System.Windows.Forms.Panel();
            this.dtgTeman = new System.Windows.Forms.DataGridView();
            this.btnTutup = new System.Windows.Forms.Button();
            this.lblOrg = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPendaftaran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPendaftaran
            // 
            this.pnlPendaftaran.BackColor = System.Drawing.Color.LightGray;
            this.pnlPendaftaran.Controls.Add(this.label1);
            this.pnlPendaftaran.Controls.Add(this.textBox2);
            this.pnlPendaftaran.Controls.Add(this.textBox1);
            this.pnlPendaftaran.Controls.Add(this.dtgTeman);
            this.pnlPendaftaran.Controls.Add(this.btnTutup);
            this.pnlPendaftaran.Controls.Add(this.lblOrg);
            this.pnlPendaftaran.Location = new System.Drawing.Point(19, 51);
            this.pnlPendaftaran.Margin = new System.Windows.Forms.Padding(10);
            this.pnlPendaftaran.Name = "pnlPendaftaran";
            this.pnlPendaftaran.Size = new System.Drawing.Size(627, 439);
            this.pnlPendaftaran.TabIndex = 4;
            // 
            // dtgTeman
            // 
            this.dtgTeman.BackgroundColor = System.Drawing.Color.White;
            this.dtgTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeman.Location = new System.Drawing.Point(15, 63);
            this.dtgTeman.Margin = new System.Windows.Forms.Padding(10);
            this.dtgTeman.Name = "dtgTeman";
            this.dtgTeman.RowHeadersWidth = 51;
            this.dtgTeman.RowTemplate.Height = 24;
            this.dtgTeman.Size = new System.Drawing.Size(591, 282);
            this.dtgTeman.TabIndex = 17;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTutup.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(481, 370);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(126, 47);
            this.btnTutup.TabIndex = 3;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrg.Location = new System.Drawing.Point(11, 14);
            this.lblOrg.Margin = new System.Windows.Forms.Padding(10);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(61, 24);
            this.lblOrg.TabIndex = 15;
            this.lblOrg.Text = "Kota:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(230, 32);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Pencarian Teman";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(178, 33);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(178, 33);
            this.textBox2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Organisasi:";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(663, 503);
            this.Controls.Add(this.pnlPendaftaran);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.pnlPendaftaran.ResumeLayout(false);
            this.pnlPendaftaran.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPendaftaran;
        private System.Windows.Forms.DataGridView dtgTeman;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}