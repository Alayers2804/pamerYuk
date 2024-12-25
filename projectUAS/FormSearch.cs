using System;
using System.Collections.Generic;
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
            InitializeDataGridView(); // Initialize DataGridView
            LoadFriends(); // Load friends after initializing the DataGridView
            dtgTeman.CellContentClick += dtgTeman_CellContentClick;

        }

        private void LoadCityFromSession()
        {
            try
            {
                Kota kota = new Kota();
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
            while (FormManager.Pop() != null) { }

            FormUtama mainForm = new FormUtama();
            mainForm.Show();
            this.Close();
        }

        private void LoadFriends()
        {
            try
            {
                User user = new User();
                List<string> friends = user.GetFriendsByCityAndOrganization(Session.KotaId, Session.OrganisasiId, koneksi);

                // Clear existing rows
                dtgTeman.Rows.Clear();

                // Populate the DataGridView with friends
                foreach (var friend in friends)
                {
                    // Add a new row for each friend
                    int rowIndex = dtgTeman.Rows.Add();
                    DataGridViewRow row = dtgTeman.Rows[rowIndex];
                    row.Cells["username"].Value = friend;
                    row.Cells["Action"].Value = "Send Request"; // This line is not needed if using button column
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading friends: " + ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            dtgTeman.Columns.Clear(); // Clear existing columns

            dtgTeman.Columns.Add("username", "Username");

            // Create a button column for sending friend requests
            DataGridViewButtonColumn sendRequestColumn = new DataGridViewButtonColumn();
            sendRequestColumn.Name = "Action"; // Set the name to match the reference in the click event
            sendRequestColumn.HeaderText = "Action";
            sendRequestColumn.Text = "Send Request";
            sendRequestColumn.UseColumnTextForButtonValue = true; // Use the same text for all buttons
            dtgTeman.Columns.Add(sendRequestColumn);
        }

        private void dtgTeman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgTeman.Columns["Action"].Index && e.RowIndex >= 0)
            {
                string selectedFriend = dtgTeman.Rows[e.RowIndex].Cells["username"].Value.ToString();
                MessageBox.Show($"Attempting to send friend request to {selectedFriend}..."); // Debugging line

                Friends friendsManager = new Friends(koneksi);
                friendsManager.SendFriendRequest(Session.Username, selectedFriend);
            }
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            LoadFriends();
        }
    }
}
