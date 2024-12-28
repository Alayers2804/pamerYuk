namespace projectUAS
{
    partial class FormProfile
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
            this.pcbProfpic = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblNik = new System.Windows.Forms.Label();
            this.lblKota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFriendlist = new System.Windows.Forms.Label();
            this.btnTutup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbProfpic
            // 
            this.pcbProfpic.Location = new System.Drawing.Point(36, 30);
            this.pcbProfpic.Name = "pcbProfpic";
            this.pcbProfpic.Size = new System.Drawing.Size(175, 207);
            this.pcbProfpic.TabIndex = 0;
            this.pcbProfpic.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(235, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblNik
            // 
            this.lblNik.AutoSize = true;
            this.lblNik.Location = new System.Drawing.Point(235, 95);
            this.lblNik.Name = "lblNik";
            this.lblNik.Size = new System.Drawing.Size(54, 16);
            this.lblNik.TabIndex = 2;
            this.lblNik.Text = "No KTP";
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Location = new System.Drawing.Point(235, 151);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(34, 16);
            this.lblKota.TabIndex = 3;
            this.lblKota.Text = "Kota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Organisasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kisah Hidup";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 146);
            this.textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 226);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblFriendlist
            // 
            this.lblFriendlist.AutoSize = true;
            this.lblFriendlist.Location = new System.Drawing.Point(33, 255);
            this.lblFriendlist.Name = "lblFriendlist";
            this.lblFriendlist.Size = new System.Drawing.Size(92, 16);
            this.lblFriendlist.TabIndex = 8;
            this.lblFriendlist.Text = "Your Friendlist";
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTutup.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(353, 529);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(126, 43);
            this.btnTutup.TabIndex = 9;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(831, 578);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.lblFriendlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKota);
            this.Controls.Add(this.lblNik);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pcbProfpic);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbProfpic;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblNik;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblFriendlist;
        private System.Windows.Forms.Button btnTutup;
    }
}