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
        private string photoPath;
        private string videoPath;
        private int kontenId;
        private string selectedFilePath;
        private string selectedFileType;

        public FormBuatKonten()
        {
            InitializeComponent();
            koneksi = new Koneksi();

            storageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "konten");
            if (!Directory.Exists(storageDirectory))
            {
                Directory.CreateDirectory(storageDirectory);
            }

            LoadFriends();
        }

        private void LoadFriends()
        {
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
            koneksi.Dispose();
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

            string caption = txtCaption.Text.Trim(); // Trim whitespace from caption
            string foto = "none"; // Default value
            string video = "none"; // Default value

            // Validation: Ensure caption is not empty and at least one media type is selected
            if (string.IsNullOrEmpty(caption))
            {
                MessageBox.Show("Caption cannot be empty.");
                return;
            }

            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a photo or video.");
                return;
            }

            // Check if a file has been selected and set the paths accordingly
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                string fileExtension = Path.GetExtension(selectedFilePath);
                string newFileName = $"konten-{username}-{DateTime.Now.Ticks}{fileExtension}"; // Unique filename
                string destinationPath = Path.Combine(storageDirectory, newFileName);

                // Copy the file to the destination path
                File.Copy(selectedFilePath, destinationPath, true);

                if (selectedFileType == "photo")
                {
                    foto = newFileName; // Store only the filename
                }
                else if (selectedFileType == "video")
                {
                    video = newFileName; // Store only the filename
                }
            }

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
                // Insert the content into the database
                kontenId = newKonten.InsertKonten(koneksi);

                // Insert tags for the content
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    string friendTag = item.ToString();
                    newKonten.InsertTag(koneksi, kontenId, friendTag);
                }

                MessageBox.Show("Content added successfully!");

                koneksi.Dispose();

                ClearFieldsAndRedirect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding content: " + ex.Message);
            }
        }


        private void ClearFieldsAndRedirect()
        {
            txtCaption.Clear();
            selectedFilePath = null;
            selectedFileType = null;
            photoPath = null;
            videoPath = null;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            FormUtama mainForm = new FormUtama();
            mainForm.Show();
            this.Close();
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
                    selectedFilePath = openFileDialog.FileName;
                    selectedFileType = radioPhoto.Checked ? "photo" : "video";

                    if (radioPhoto.Checked)
                    {
                        pictureBox1.Image = Image.FromFile(selectedFilePath);
                        pictureBox1.Visible = true;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
                        panel1.Visible = false;
                    }
                    else if (radioVideo.Checked)
                    {
                        panel1.Visible = true;
                        pictureBox1.Visible = false;
                    }
                }
            }
        }
    }
}
