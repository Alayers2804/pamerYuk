using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Class_POS;

namespace projectUAS
{
    public partial class KontenControl : UserControl
    {
        private Panel panel1;
        private Button btnComment;
        private TextBox txtCaption;
        private TextBox txtContent;
        private TextBox txtComment;
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
            txtContent.Text = konten.Video; 
            txtCaption.Text = konten.Caption;
            kontenId = konten.Id; 
            LoadComments(konten.Id); 
        }

        private void LoadComments(int kontenId)
        {
            // Load comments from the database and display them in the comments panel
            List<Komen> comments = new Komen().GetCommentsByKontenId(koneksi, kontenId);
            Console.WriteLine($"Number of comments loaded: {comments.Count}");

            panel1.Controls.Clear(); // Clear existing comments

            foreach (var comment in comments)
            {
                Label commentLabel = new Label
                {
                    Text = $"{comment.Username.Username}: {comment.Komentar}", // Display username and comment
                    AutoSize = true, // Allow the label to resize based on content
                    MaximumSize = new Size(panel1.Width - 20, 0), // Set a maximum width for the label
                    Padding = new Padding(5) // Add some padding for better readability
                };
                panel1.Controls.Add(commentLabel); // Add the comment label to the comments panel
            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (Session.Username == null)
            {
                MessageBox.Show("You must be logged in to add a comment.");
                return; // Exit the method if not logged in
            }

            string newComment = txtComment.Text;
            if (!string.IsNullOrEmpty(newComment))
            {
                Komen comment = new Komen
                {
                    Komentar = newComment,
                    Tanggal = DateTime.Now,
                    Username = new User { Username = Session.Username },
                    KontenId = new Konten { Id = kontenId } // Use the stored kontenId
                };

                try
                {
                    comment.InsertKomen(koneksi); // Insert the comment into the database
                    LoadComments(kontenId); // Reload comments to show the new one
                    txtComment.Clear(); // Clear the input field
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
            this.btnComment = new System.Windows.Forms.Button();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(42, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 107);
            this.panel1.TabIndex = 0;
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(42, 502);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(131, 35);
            this.btnComment.TabIndex = 1;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(42, 160);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.ReadOnly = true;
            this.txtCaption.Size = new System.Drawing.Size(544, 107);
            this.txtCaption.TabIndex = 2;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(42, 35);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(544, 107);
            this.txtContent.TabIndex = 3;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(42, 443);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(449, 41);
            this.txtComment.TabIndex = 4;
            // 
            // KontenControl
            // 
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.panel1);
            this.Name = "KontenControl";
            this.Size = new System.Drawing.Size(625, 568);
            this.Load += new System.EventHandler(this.KontenControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void KontenControl_Load(object sender, EventArgs e)
        {

        }
    }
}
