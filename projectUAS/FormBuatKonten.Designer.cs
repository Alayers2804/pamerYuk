
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioPhoto = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.pnlPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPost
            // 
            this.pnlPost.BackColor = System.Drawing.Color.LightGray;
            this.pnlPost.Controls.Add(this.btnSelectFile);
            this.pnlPost.Controls.Add(this.panel1);
            this.pnlPost.Controls.Add(this.pictureBox1);
            this.pnlPost.Controls.Add(this.radioVideo);
            this.pnlPost.Controls.Add(this.radioPhoto);
            this.pnlPost.Controls.Add(this.checkedListBox1);
            this.pnlPost.Controls.Add(this.label1);
            this.pnlPost.Controls.Add(this.txtCaption);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(116, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 128);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(116, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 128);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Location = new System.Drawing.Point(185, 160);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(64, 20);
            this.radioVideo.TabIndex = 24;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Video";
            this.radioVideo.UseVisualStyleBackColor = true;
            // 
            // radioPhoto
            // 
            this.radioPhoto.AutoSize = true;
            this.radioPhoto.Location = new System.Drawing.Point(116, 160);
            this.radioPhoto.Name = "radioPhoto";
            this.radioPhoto.Size = new System.Drawing.Size(63, 20);
            this.radioPhoto.TabIndex = 23;
            this.radioPhoto.TabStop = true;
            this.radioPhoto.Text = "Photo";
            this.radioPhoto.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(116, 451);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(347, 89);
            this.checkedListBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 451);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tag:";
            // 
            // txtCaption
            // 
            this.txtCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaption.Location = new System.Drawing.Point(116, 287);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(10);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(347, 124);
            this.txtCaption.TabIndex = 20;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(24, 287);
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
            // btnSelectFile
            // 
            this.btnSelectFile.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(116, 198);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(15);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(133, 44);
            this.btnSelectFile.TabIndex = 27;
            this.btnSelectFile.Text = "Pilih File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.RadioButton radioPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelectFile;
    }
}