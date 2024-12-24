using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_POS;

namespace projectUAS
{
    public partial class FormBuatKonten : Form
    {
        private Koneksi koneksi;
        public FormBuatKonten()
        {
            koneksi = new Koneksi();
            
            InitializeComponent();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();

            Form previousForm = FormManager.Pop();
            if (previousForm != null)
            {
                previousForm.Show();
            }
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
            string foto = txtMedia.Text;
            string video = txtMedia.Text;

            
            Konten newKonten = new Konten
            {
                Caption = caption,
                Foto = foto,
                Video = video,
                TglUpload = DateTime.Now,
                Username = new User { Username = username }
            };

            try
            {
                newKonten.InsertKonten(koneksi);
                MessageBox.Show("Content added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding content: " + ex.Message);
            }
        }


    }
}
