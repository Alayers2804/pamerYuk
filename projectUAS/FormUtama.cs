using System;
using System.Windows.Forms;

namespace projectUAS
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void Login_click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormLogin loginForm = new FormLogin();
            FormManager.ClearAndShow(loginForm); // Clear existing forms and show the login form
        }

        private void Regist_click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormDaftar formDaftar = new FormDaftar();
            FormManager.ClearAndShow(formDaftar); // Clear existing forms and show the registration form
        }

        private void Post_click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormBuatKonten postForm = new FormBuatKonten();
            FormManager.ClearAndShow(postForm); // Clear existing forms and show the post form
        }

        private void Chat_click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormChat formChat = new FormChat();
            FormManager.ClearAndShow(formChat); // Clear existing forms and show the chat form
        }

        private void Search_click(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (Session.Username == null || Session.KotaId == 0 || Session.OrganisasiId == 0)
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return; // Exit the method if not logged in
            }

            FormManager.Push(this);
            FormSearch searchForm = new FormSearch();
            FormManager.ClearAndShow(searchForm); // Clear existing forms and show the search form
        }

        private void organizationForm_Click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormDaftarOrganisasi formOrganization = new FormDaftarOrganisasi();
            FormManager.ClearAndShow(formOrganization); // Clear existing forms and show the organization form
        }

        private void KotaForm_Click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormDaftarKota formCities = new FormDaftarKota();
            FormManager.ClearAndShow(formCities); // Clear existing forms and show the city form
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.Username = null;
            FormLogin loginForm = new FormLogin();
            FormManager.ClearAndShow(loginForm); // Clear existing forms and show the login form
        }
    }
}
