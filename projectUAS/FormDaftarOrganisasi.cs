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
    public partial class FormDaftarOrganisasi : Form
    {   
        private Organisasi organisasi;
        private Koneksi koneksi;
        public FormDaftarOrganisasi()
        {   
            organisasi = new Organisasi();
            koneksi = new Koneksi();
            InitializeComponent();
            LoadOrganization();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            koneksi.Dispose();

            while (FormManager.Pop() != null) { }

            

            FormUtama mainForm = new FormUtama();
            mainForm.Show();


            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormManager.Push(this);
            FormTambahOrganisasi addOrganizationForm = new FormTambahOrganisasi();
            addOrganizationForm.ShowDialog();

        }

        private void LoadOrganization()
        {
            try
            {
                List<string> orgList = organisasi.GetOrganizations(koneksi);


                DataTable orgDataTable = new DataTable();
                orgDataTable.Columns.Add("Organizations Name");

                foreach (var org in orgList)
                {
                    orgDataTable.Rows.Add(org);
                }


                dtgOrg.DataSource = orgDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cities: " + ex.Message);
            }
        }
    }
}
