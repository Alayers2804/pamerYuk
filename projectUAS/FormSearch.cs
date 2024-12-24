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
    public partial class FormSearch : Form
    {
        private Kota kota;
        private Organisasi organisasi;
        private Koneksi koneksi;
        public FormSearch()
        {
            InitializeComponent();

            koneksi = new Koneksi(); // Initialize the database connection
            LoadCityFromSession();
            LoadOrganizationFromSession();
        }

        private void LoadCityFromSession()
        {
            try
            {
                Kota kota = new Kota();
                // Get the city name using the KotaId from the session
                string cityName = kota.GetCityNameById(Session.KotaId, koneksi);
                textBox1.Text = cityName ?? "City not found"; // Set the city name in the text box
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading city: " + ex.Message);
            }
        }

        private void LoadOrganizationFromSession()
        {
            try
            {
                Organisasi organisasi = new Organisasi();
                // Get the organization name using the OrganisasiId from the session
                string organizationName = organisasi.GetOrganizationNameById(Session.OrganisasiId, koneksi);
                textBox2.Text = organizationName ?? "Organization not found"; // Set the organization name in the text box
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organization: " + ex.Message);
            }
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
    }
}
