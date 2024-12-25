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
    public partial class FormDaftarKota : Form
    {
        private Koneksi Koneksi;
        private Kota kota;
        public FormDaftarKota()
        {
            kota = new Kota();
            Koneksi = new Koneksi();
            InitializeComponent();
            LoadCities();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {

            while (FormManager.Pop() != null) { }


            FormUtama mainForm = new FormUtama();
            mainForm.Show();


            this.Close();
        }

        private void LoadCities()
        {
            try
            {
                List<string> cityList = kota.GetCity(Koneksi);

                
                DataTable cityDataTable = new DataTable();
                cityDataTable.Columns.Add("City Name"); 

                foreach (var city in cityList)
                {
                    cityDataTable.Rows.Add(city);
                }

                
                dtgKota.DataSource = cityDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cities: " + ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormTambahKota addCityForm = new FormTambahKota();
            addCityForm.ShowDialog();
        }
    }
}
