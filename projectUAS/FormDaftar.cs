using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_POS;

namespace projectUAS
{
    public partial class FormDaftar : Form
    {
        private Koneksi koneksi;
        private Organisasi organisasi;
        private Kota kota;

        private string imagePath;

        public FormDaftar()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            organisasi = new Organisasi();
            kota = new Kota();

            CreatePicturesDirectory();
            LoadCities();
            cbxKota.SelectedIndexChanged += cbxKota_SelectedIndexChanged; 
            cbxTingkat.SelectedIndexChanged += cbxTingkat_SelectedIndexChanged; 
        }

        private void btn_Tutup(object sender, EventArgs e)
        {
            
            while (FormManager.Pop() != null) { }

            FormUtama mainForm = new FormUtama();
            mainForm.Show();

            this.Close();
        }


        private void cbxTingkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (cbxTingkat.SelectedItem != null)
            {
                string selectedOrganization = cbxTingkat.SelectedItem.ToString();

                if (selectedOrganization == "Add New Organization")
                {
                    FormTambahOrganisasi addOrganizationForm = new FormTambahOrganisasi();
                    addOrganizationForm.ShowDialog();
                    LoadOrganizations();
                }
            }
        }

        private void LoadOrganizations()
        {
            try
            {
                BindingList<string> organizations = new BindingList<string>();
                int selectedCityId = GetSelectedCityId(); // Get the selected city ID
                List<string> orgList = organisasi.GetOrganizations(selectedCityId, koneksi); // Load organizations based on selected city

                // Add an empty entry as the default selection
                organizations.Add(string.Empty); // Empty entry for default selection

                foreach (var org in orgList)
                {
                    organizations.Add(org);
                }

                organizations.Add("Add New Organization");
                cbxTingkat.DataSource = organizations;

                cbxTingkat.Enabled = organizations.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organizations: " + ex.Message);
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

                cities.Add("Add New City");
                cbxKota.DataSource = cities;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cities: " + ex.Message);
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
           

            User newUser = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                TglLahir = dtpbirthDate.Value,
                NoKTP = txtKTP.Text,
                Foto = imagePath,
                IdKota = new Kota(GetSelectedCityId(), cbxKota.SelectedItem.ToString())
            };

            try
            {
                newUser.InsertUser(koneksi);
                MessageBox.Show("User registered successfully!");

                int organisasiId = GetSelectedOrganizationId();
                string thawal = txtThnAwl.Text;
                string thakhir = txtThnAkr.Text;
                string deskripsi = txtDeskripsi.Text;

                newUser.InsertDescription(koneksi, organisasiId, thawal, thakhir, deskripsi);
                MessageBox.Show("Description registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering user: " + ex.Message);
            }
        }

        private int GetSelectedCityId()
        {
            if (cbxKota.SelectedItem != null)
            {
                string selectedCity = cbxKota.SelectedItem.ToString();
                return kota.GetCityIdByName(selectedCity, koneksi);
            }
            return 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(openFileDialog.FileName);
                    string picturesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures");

                    // Check if the pictures directory exists, if not, create it
                    if (!Directory.Exists(picturesDirectory))
                    {
                        Directory.CreateDirectory(picturesDirectory);
                    }

                    string destinationPath = Path.Combine(picturesDirectory, fileName);

                    // Copy the file to the destination path
                    File.Copy(openFileDialog.FileName, destinationPath, true); // Overwrite if exists

                    imagePath = destinationPath;

                    // Load the image into the PictureBox
                    pictureBox1.Image = new Bitmap(destinationPath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Set the SizeMode to Zoom
                }
            }
        }



        private int GetSelectedOrganizationId()
        {
            if (cbxTingkat.SelectedItem != null)
            {
                string selectedOrganization = cbxTingkat.SelectedItem.ToString();
                return organisasi.GetOrganizationIdByName(selectedOrganization, koneksi);
            }
            return 0; // Return 0 if no organization is selected
        }

        private void cbxKota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKota.SelectedItem != null)
            {
                if (cbxKota.SelectedItem.ToString() == "Add New City")
                {
                    FormTambahKota addCityForm = new FormTambahKota();
                    addCityForm.ShowDialog();
                    LoadCities(); // Reload cities after adding a new one
                }
                else
                {
                    LoadOrganizations(); // Load organizations based on the selected city
                }
            }
        }

        private void CreatePicturesDirectory()
        {
            string picturesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures");
            if (!Directory.Exists(picturesPath))
            {
                Directory.CreateDirectory(picturesPath); // Create the directory if it doesn't exist
            }
        }
    }
}
