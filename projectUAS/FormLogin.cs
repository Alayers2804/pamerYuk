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
    public partial class FormLogin : Form
    {
        private Koneksi koneksi;
        public FormLogin()
        {
            koneksi = new Koneksi();
            InitializeComponent();
            this.FormClosing += FormLogin_FormClosing;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(); // Trim whitespace from username
            string password = txtPassword.Text.Trim(); // Trim whitespace from password

            // Validate that username and password are not empty
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password cannot be empty.");
                txtPassword.Focus();
                return;
            }

            User user = new User();
            if (user.ValidateCredentials(username, password))
            {
                Session.Username = username;
                Session.KotaId = user.GetKotaId(username, koneksi);
                Session.OrganisasiId = user.GetOrganisasiId(username, koneksi);

                koneksi.Dispose();

                FormUtama formUtama = new FormUtama();
                FormManager.ClearAndShow(formUtama);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }



        private void btnDaftar_Click(object sender, EventArgs e)
        {
            FormDaftar formDaftar = new FormDaftar();
            FormManager.ClearAndShow(formDaftar);
            this.Hide();
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtama formUtama = new FormUtama();
            FormManager.ClearAndShow(formUtama);
            this.Hide();
        }
    }
}
