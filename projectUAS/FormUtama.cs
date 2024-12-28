using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Class_POS;

namespace projectUAS
{

    public partial class FormUtama : Form
    {
        private Koneksi koneksi;
        private Konten konten;
        public FormUtama()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            konten = new Konten();
            this.FormClosing += FormUtama_FormClosing; // Subscribe to the FormClosing event

        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            LoadKonten();
        }

        private void Login_click(object sender, EventArgs e)
        {
            if (Session.Username != null || Session.KotaId != 0 || Session.OrganisasiId != 0)
            {
                MessageBox.Show("You are already logged in.");
                return;
            }
            FormManager.Push(this);
            FormLogin loginForm = new FormLogin();
            FormManager.ClearAndShow(loginForm);
        }

        private void Regist_click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormDaftar formDaftar = new FormDaftar();
            FormManager.ClearAndShow(formDaftar);
        }

        private void Post_click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormBuatKonten postForm = new FormBuatKonten();
            FormManager.ClearAndShow(postForm); 
        }

        private void Chat_click(object sender, EventArgs e)
        {
            if (Session.Username == null || Session.KotaId == 0 || Session.OrganisasiId == 0)
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return;
            }
            FormManager.Push(this);
            FormChat formChat = new FormChat();
            FormManager.ClearAndShow(formChat); 
        }

        private void Search_click(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (Session.Username == null || Session.KotaId == 0 || Session.OrganisasiId == 0)
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return; 
            }

            FormManager.Push(this);
            FormSearch searchForm = new FormSearch();
            FormManager.ClearAndShow(searchForm); 
        }

        private void organizationForm_Click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormDaftarOrganisasi formOrganization = new FormDaftarOrganisasi();
            FormManager.ClearAndShow(formOrganization); 
        }

        private void KotaForm_Click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormDaftarKota formCities = new FormDaftarKota();
            FormManager.ClearAndShow(formCities); 
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.Username == null)
            {
                MessageBox.Show("You are not logged in.");
                return;
            }
            FormManager.Push(this);
            Session.Username = null;
            FormLogin loginForm = new FormLogin();
            FormManager.ClearAndShow(loginForm);
        }

        private void LoadKonten()
        {
            try
            {
                List<Konten> kontenList = konten.GetAllKonten(koneksi);
                flowLayoutPanel1.Controls.Clear(); // Clear existing controls

                foreach (var konten in kontenList)
                {
                    KontenControl kontenControl = new KontenControl();
                    kontenControl.SetKonten(konten);
                    flowLayoutPanel1.Controls.Add(kontenControl); // Add the control to the FlowLayoutPanel
                }

                // Handle empty content
                if (kontenList.Count == 0)
                {
                    MessageBox.Show("No content available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading content: " + ex.Message);
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Session.Username == null || Session.KotaId == 0 || Session.OrganisasiId == 0)
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return;
            }

            FormManager.Push(this);
            FormProfile profileForm = new FormProfile();
            FormManager.ClearAndShow(profileForm);
        }

        private void FormUtama_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show a confirmation dialog before exiting
            var result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the closing event
            }
        }
    }
}
