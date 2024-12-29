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
    public partial class FormTambahKota : Form
    {
        private Kota kota;
        private Koneksi koneksi;
        public FormTambahKota()
        {
            InitializeComponent();

            kota = new Kota();
            koneksi = new Koneksi();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string cityName = txtNama.Text;

            // Try to convert the ID from the TextBox to an integer
            int cityId;
            if (!int.TryParse(id, out cityId))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            // Create a new instance of Kota
            Kota newKota = new Kota(cityId, cityName);

            try
            {
                // Insert the new city into the database
                newKota.InsertKota(koneksi);
                MessageBox.Show("City added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding city: " + ex.Message);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();

            koneksi.Dispose();
        }
    }
}
