
namespace projectUAS
{
    partial class FormBuatKonten
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
            this.pnlPost = new System.Windows.Forms.Panel();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtTag1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTag2 = new System.Windows.Forms.TextBox();
            this.pnlPost.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPost
            // 
            this.pnlPost.BackColor = System.Drawing.Color.LightGray;
            this.pnlPost.Controls.Add(this.txtTag2);
            this.pnlPost.Controls.Add(this.txtTag1);
            this.pnlPost.Controls.Add(this.label1);
            this.pnlPost.Controls.Add(this.txtCaption);
            this.pnlPost.Controls.Add(this.txtMedia);
            this.pnlPost.Controls.Add(this.lblCaption);
            this.pnlPost.Controls.Add(this.btnTutup);
            this.pnlPost.Controls.Add(this.btnTambah);
            this.pnlPost.Controls.Add(this.lblMedia);
            this.pnlPost.Location = new System.Drawing.Point(17, 48);
            this.pnlPost.Margin = new System.Windows.Forms.Padding(10);
            this.pnlPost.Name = "pnlPost";
            this.pnlPost.Size = new System.Drawing.Size(504, 673);
            this.pnlPost.TabIndex = 13;
            // 
            // txtCaption
            // 
            this.txtCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaption.Location = new System.Drawing.Point(116, 113);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(10);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(347, 259);
            this.txtCaption.TabIndex = 20;
            // 
            // txtMedia
            // 
            this.txtMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedia.Location = new System.Drawing.Point(116, 10);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(10);
            this.txtMedia.Multiline = true;
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(347, 83);
            this.txtMedia.TabIndex = 19;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(10, 119);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(10);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(90, 24);
            this.lblCaption.TabIndex = 18;
            this.lblCaption.Text = "Caption:";
            // 
            // btnTutup
            // 
            this.btnTutup.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(363, 614);
            this.btnTutup.Margin = new System.Windows.Forms.Padding(15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(126, 44);
            this.btnTutup.TabIndex = 17;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(14, 614);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(15);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(149, 44);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(24, 16);
            this.lblMedia.Margin = new System.Windows.Forms.Padding(10);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(73, 24);
            this.lblMedia.TabIndex = 15;
            this.lblMedia.Text = "Media:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(69, 32);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Post";
            // 
            // txtTag1
            // 
            this.txtTag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTag1.Location = new System.Drawing.Point(116, 392);
            this.txtTag1.Margin = new System.Windows.Forms.Padding(10);
            this.txtTag1.Multiline = true;
            this.txtTag1.Name = "txtTag1";
            this.txtTag1.Size = new System.Drawing.Size(347, 30);
            this.txtTag1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tag:";
            // 
            // txtTag2
            // 
            this.txtTag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTag2.Location = new System.Drawing.Point(116, 442);
            this.txtTag2.Margin = new System.Windows.Forms.Padding(10);
            this.txtTag2.Multiline = true;
            this.txtTag2.Name = "txtTag2";
            this.txtTag2.Size = new System.Drawing.Size(347, 30);
            this.txtTag2.TabIndex = 23;
            // 
            // FormBuatKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(542, 739);
            this.Controls.Add(this.pnlPost);
            this.Controls.Add(this.lblHeader);
            this.Name = "FormBuatKonten";
            this.Text = "FormBuatKonten";
            this.pnlPost.ResumeLayout(false);
            this.pnlPost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPost;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtTag1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTag2;
    }
}