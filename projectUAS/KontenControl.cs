using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Class_POS;

namespace projectUAS
{
    public partial class KontenControl : UserControl
    {
        private Panel panel1;
        private Button btnComment;
        private TextBox txtCaption;
        private TextBox txtComment;
        private PictureBox pictureBox;
        private Panel videoPanel; 
        private Label lblUploader; 
        private Label lblTaggedUsers;
        private Koneksi koneksi;
        private int kontenId;

        public KontenControl()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            koneksi = new Koneksi();
        }

        public void SetKonten(Konten konten)
        {
            txtCaption.Text = konten.Caption;
            kontenId = konten.Id;

            lblUploader.Text = $"Uploaded by: {konten.User.Username}";

            List<string> taggedUsers = konten.GetTaggedUsers(koneksi);
            if (taggedUsers != null && taggedUsers.Count > 0)
            {
                lblTaggedUsers.Text = "Tagged Users: " + string.Join(", ", taggedUsers);
            }
            else
            {
                lblTaggedUsers.Text = "Tagged Users: None";
            }

            if (!string.IsNullOrEmpty(konten.Foto) && konten.Foto != "none")
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, konten.Foto);
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Visible = true;
                    videoPanel.Visible = false;
                }
                else
                {
                    pictureBox.Visible = false;
                }
            }
            else if (!string.IsNullOrEmpty(konten.Video) && konten.Video != "none")
            {
                videoPanel.Visible = true;
                pictureBox.Visible = false;
            }
            else
            {
                pictureBox.Visible = false;
                videoPanel.Visible = false;
            }

            // Load comments for the current konten
            LoadComments(kontenId); // Ensure comments are loaded
        }


        private void LoadComments(int kontenId)
        {
            List<Komen> comments = new Komen().GetCommentsByKontenId(koneksi, kontenId);
            Console.WriteLine($"Number of comments loaded: {comments.Count}");

            panel1.Controls.Clear();

            int yOffset = 0;

            foreach (var comment in comments)
            {
                Label commentLabel = new Label
                {
                    Text = $"{comment.Username.Username}: {comment.Komentar}",
                    AutoSize = true,
                    MaximumSize = new Size(panel1.Width - 20, 0),
                    Padding = new Padding(5),
                    Location = new Point(5, yOffset)
                };

                panel1.Controls.Add(commentLabel);
                yOffset += commentLabel.Height + 5;
            }

            panel1.Height = Math.Max(yOffset, 107);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (Session.Username == null)
            {
                MessageBox.Show("You must be logged in to add a comment.");
                return;
            }

            string newComment = txtComment.Text;
            if (!string.IsNullOrEmpty(newComment))
            {
                Komen comment = new Komen
                {
                    Komentar = newComment,
                    Tanggal = DateTime.Now,
                    Username = new User { Username = Session.Username },
                    KontenId = new Konten { Id = kontenId }
                };

                try
                {
                    comment.InsertKomen(koneksi);
                    LoadComments(kontenId);
                    txtComment.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding comment: " + ex.Message);
                }
            }
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.lblUploader = new System.Windows.Forms.Label();
            this.lblTaggedUsers = new System.Windows.Forms.Label();
            this.btnComment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.videoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 134);
            this.panel1.TabIndex = 0;
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(20, 171);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.ReadOnly = true;
            this.txtCaption.Size = new System.Drawing.Size(580, 100);
            this.txtCaption.TabIndex = 2;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(20, 493);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(580, 40);
            this.txtComment.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(20, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(580, 220);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // videoPanel
            // 
            this.videoPanel.Controls.Add(this.txtCaption);
            this.videoPanel.Location = new System.Drawing.Point(20, 35);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(580, 220);
            this.videoPanel.TabIndex = 8;
            this.videoPanel.Visible = false;
            // 
            // lblUploader
            // 
            this.lblUploader.AutoSize = true;
            this.lblUploader.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUploader.Location = new System.Drawing.Point(20, 260);
            this.lblUploader.Name = "lblUploader";
            this.lblUploader.Size = new System.Drawing.Size(0, 19);
            this.lblUploader.TabIndex = 5;
            // 
            // lblTaggedUsers
            // 
            this.lblTaggedUsers.AutoSize = true;
            this.lblTaggedUsers.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTaggedUsers.Location = new System.Drawing.Point(20, 280);
            this.lblTaggedUsers.Name = "lblTaggedUsers";
            this.lblTaggedUsers.Size = new System.Drawing.Size(0, 19);
            this.lblTaggedUsers.TabIndex = 6;
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(20, 539);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(131, 35);
            this.btnComment.TabIndex = 1;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // KontenControl
            // 
            this.Controls.Add(this.lblTaggedUsers);
            this.Controls.Add(this.lblUploader);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.videoPanel);
            this.Name = "KontenControl";
            this.Size = new System.Drawing.Size(757, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.videoPanel.ResumeLayout(false);
            this.videoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
