using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Class_POS;

namespace projectUAS
{
    public partial class FormBuatKonten : Form
    {
        private Koneksi koneksi;
        private string storageDirectory;
        private string photoPath; // Variable to store the photo path
        private string videoPath; // Variable to store the video path

        public FormBuatKonten()
        {
            koneksi = new Koneksi();
            InitializeComponent();

            storageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "konten");

            if (!Directory.Exists(storageDirectory))
            {
                Directory.CreateDirectory(storageDirectory);
            }

            string username = Session.Username;
            Friends friendsManager = new Friends(koneksi);
            List<string> friends = friendsManager.GetFriends(username);

            foreach (var friend in friends)
            {
                checkedListBox1.Items.Add(friend);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            while (FormManager.Pop() != null) { }

            FormUtama mainForm = new FormUtama();
            mainForm.Show();
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string username = Session.Username;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("You must be logged in to create content.");
                FormLogin loginForm = new FormLogin();
                loginForm.Show();
                this.Hide();
                return;
            }

            string caption = txtCaption.Text;
            string foto = photoPath ?? "none"; // Use the stored photo path or "none"
            string video = videoPath ?? "none"; // Use the stored video path or "none"

            Konten newKonten = new Konten
            {
                Caption = caption,
                Foto = foto,
                Video = video,
                TglUpload = DateTime.Now,
                User = new User { Username = username }
            };

            try
            {
                int newId = newKonten.InsertKonten(koneksi);

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    string friendTag = item.ToString();
                    newKonten.InsertTag(koneksi, newId, friendTag);
                }

                MessageBox.Show("Content added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding content: " + ex.Message);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (radioPhoto.Checked)
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
                }
                else if (radioVideo.Checked)
                {
                    openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov|All Files|*.*";
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    string destinationPath = Path.Combine(storageDirectory, fileName);

                    File.Copy(filePath, destinationPath, true);

                    if (radioPhoto.Checked)
                    {
                        photoPath = Path.Combine("konten", fileName); // Store the relative path for the photo
                        pictureBox1.Image = Image.FromFile(destinationPath);
                        pictureBox1.Visible = true;
                        panel1.Visible = false;
                    }
                    else if (radioVideo.Checked)
                    {
                        videoPath = Path.Combine("konten", fileName); // Store the relative path for the video
                        panel1.Visible = true;
                        pictureBox1.Visible = false;
                    }
                }
            }
        }
    }
}
