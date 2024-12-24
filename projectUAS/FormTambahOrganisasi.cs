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
    public partial class FormTambahOrganisasi : Form
    {
        private Kota kota;
        private Koneksi koneksi;
        public FormTambahOrganisasi()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            kota = new Kota();
            LoadCities();
            
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string takenId = txtID.Text;
            int id;

            // Try to convert the ID from the TextBox to an integer
            if (!int.TryParse(takenId, out id))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            string orgName = txtNama.Text;

            // Create a new instance of Organisasi
            Organisasi newOrganisasi = new Organisasi(id, orgName, new Kota());

            // Get the selected city from the ComboBox
            string selectedCity = cbxKota.SelectedItem.ToString();
            int cityId = kota.GetCityIdByName(selectedCity, koneksi);
            newOrganisasi.IdKota = new Kota(cityId, selectedCity); // Set the city for the organization

            try
            {
                // Insert the new organization into the database
                newOrganisasi.InsertOrganisasi(koneksi);
                MessageBox.Show("Organization added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding organization: " + ex.Message);
            }
        }


        private void LoadCities()
        {
            try
            {
                BindingList<string> cities = new BindingList<string>();
                List<string> cityList = kota.GetCity(koneksi);

                foreach (var city in cityList)
                {
                    cities.Add(city);
                }

                cbxKota.DataSource = cities;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cities: " + ex.Message);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
