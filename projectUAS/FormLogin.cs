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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = new User();
            if (user.ValidateCredentials(username, password))
            {
                Session.Username = username;
                Session.KotaId = user.GetKotaId(username, koneksi);
                Session.OrganisasiId = user.GetOrganisasiId(username, koneksi);

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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true; 
            this.Hide(); 
        }
    }
}
