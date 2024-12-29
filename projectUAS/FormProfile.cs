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
    public partial class FormProfile : Form
    {
        private Koneksi koneksi;
        private User user;
        private Kota kota;
        private Organisasi organisasi;

        public FormProfile()
        {
            InitializeComponent();
            koneksi = new Koneksi(); // Initialize the database connection once
            user = new User();
            InitializeDataGridView(); // Initialize the DataGridView

            // Subscribe to the CellContentClick event
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            string currentUsername = Session.Username; // Assuming you have a session management system
            LoadUserProfile(currentUsername); // Load user profile
            LoadFriendlist(currentUsername); // Load pending friend requests
        }


        public void LoadUserProfile(string username)
        {
            try
            {
              
                user = user.GetUserProfile(username, koneksi); // Get user profile

                if (user != null)
                {
                    lblUsername.Text = user.Username;
                    lblNik.Text = user.NoKTP;
                    lblKota.Text = new Kota().GetCityNameById(user.IdKota.Id, koneksi); // Get city name
                    LoadProfilePicture(user.Foto); // Load the profile picture

                    // Load organization and description
                    string description = user.GetUserDescription(username, koneksi);
                    textBox1.Text = description; // Set the description in the TextBox

                    // Optionally load organization name if needed
                    int organisasiId = user.GetOrganisasiId(username, koneksi);
                    label1.Text = new Organisasi().GetOrganizationNameById(organisasiId, koneksi); // Get organization name
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user profile: " + ex.Message);
            }
        }

        private void LoadProfilePicture(string fotoFilename)
        {
            // Define the directory where the pictures are stored
            string picturesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures");

            // Combine the directory with the filename to get the full path
            string fullPath = Path.Combine(picturesDirectory, fotoFilename);

            // Check if the file exists
            if (File.Exists(fullPath))
            {
                // Load the image into the PictureBox
                pcbProfpic.Image = Image.FromFile(fullPath);
                pcbProfpic.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                // If the file does not exist, set the PictureBox image to null
                pcbProfpic.Image = null;
            }
        }

        private void LoadFriendlist(string username)
        {
            try
            {
                Friends friendsManager = new Friends(koneksi);
                var pendingRequests = friendsManager.GetPendingRequests(username);
                var acceptedFriends = friendsManager.GetFriends(username);
                var favoriteFriends = friendsManager.GetFavoriteFriends(username); // Get favorite friends

                // Clear existing rows
                dataGridView1.Rows.Clear();

                // Populate the DataGridView with pending requests
                foreach (var request in pendingRequests)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["Friends Name"].Value = request.requester;
                    row.Cells["Status"].Value = "Pending";
                    row.Cells["Accept"].Value = "Accept";
                    row.Cells["Favorite"].Value = "";
                }

                // Populate the DataGridView with accepted friends
                foreach (var friend in acceptedFriends)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["Friends Name"].Value = friend;

                    // Check if the friend is in the favorites list
                    if (friendsManager.IsFavorited(friend, username))
                    {
                        row.Cells["Status"].Value = "Favorite"; // Set status to "Favorite"
                        row.Cells["Favorite"].Value = "Unfavorite"; // Show the Unfavorite button
                    }
                    else
                    {
                        row.Cells["Status"].Value = "Friend";
                        row.Cells["Favorite"].Value = "Favorite";
                    }

                    row.Cells["Accept"].Value = ""; // No button for accepted friends
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading friend requests: " + ex.Message);
            }
        }


        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Friends Name", "Friends Name");
            dataGridView1.Columns.Add("Status", "Status");

            // Add a button column for accepting friend requests
            DataGridViewButtonColumn acceptColumn = new DataGridViewButtonColumn();
            acceptColumn.Name = "Accept";
            acceptColumn.HeaderText = "Accept";
            acceptColumn.Text = "Accept";
            acceptColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(acceptColumn);

            // Add a button column for favoriting friends
            DataGridViewButtonColumn favoriteColumn = new DataGridViewButtonColumn();
            favoriteColumn.Name = "Favorite";
            favoriteColumn.HeaderText = "Favorite";
            favoriteColumn.Text = "Favorite";
            favoriteColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(favoriteColumn);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Accept" column and the row index is valid
            if (e.ColumnIndex == dataGridView1.Columns["Accept"].Index && e.RowIndex >= 0)
            {
                // Ensure the row is not null and has the expected cells
                if (dataGridView1.Rows[e.RowIndex] != null)
                {
                    // Get the requester value safely
                    var requesterCell = dataGridView1.Rows[e.RowIndex].Cells["Friends Name"];
                    if (requesterCell != null && requesterCell.Value != null)
                    {
                        string requester = requesterCell.Value.ToString();
                        string currentUser = Session.Username;

                        // Check if currentUser is not null
                        if (string.IsNullOrEmpty(currentUser))
                        {
                            MessageBox.Show("Current user is not logged in.");
                            return;
                        }

                        Friends friendsManager = new Friends(koneksi);

                        // Check if the user is already friends
                        if (friendsManager.IsAlreadyFriends(currentUser, requester))
                        {
                            MessageBox.Show("You are already friends with this user.");
                            return; 
                        }

                        try
                        {
                            // Accept the friend request
                            friendsManager.AcceptFriendRequest(requester, currentUser);
                            MessageBox.Show($"Friend request from {requester} accepted.");

                            dataGridView1.Rows[e.RowIndex].Cells["Status"].Value = "Friend"; // Update status to "Friend"
                            dataGridView1.Rows[e.RowIndex].Cells["Accept"].Value = ""; // Clear the button
                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show(ex.Message); // Show the error message if no pending request
                        }

                        dataGridView1.Rows[e.RowIndex].Cells["Status"].Value = "Friend"; // Update status to "Friend"
                        dataGridView1.Rows[e.RowIndex].Cells["Accept"].Value = ""; // Clear the button
                    }
                    else
                    {
                        MessageBox.Show("Requester information is missing.");
                    }
                }
                else
                {
                    MessageBox.Show("Selected row is invalid.");
                }
            }

            // Check if the clicked cell is in the "Favorite" column
            if (e.ColumnIndex == dataGridView1.Columns["Favorite"].Index && e.RowIndex >= 0)
            {
                var friendNameCell = dataGridView1.Rows[e.RowIndex].Cells["Friends Name"];
                if (friendNameCell != null && friendNameCell.Value != null)
                {
                    string friendName = friendNameCell.Value.ToString();
                    Friends friendsManager = new Friends(koneksi);

                    // Check if the friend is already a favorite
                    if (dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Favorite")
                    {
                        // Unfavorite the friend
                        friendsManager.RemoveFromFavorites(friendName, Session.Username);
                        MessageBox.Show($"{friendName} has been removed from favorites.");

                        // Check if the friend is still in the accepted friends list
                        if (friendsManager.IsAlreadyFriends(friendName, Session.Username))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells["Status"].Value = "Friend"; // Set status back to "Friend"
                        }
                        else
                        {
                            dataGridView1.Rows[e.RowIndex].Cells["Status"].Value = ""; // Clear status if not friends
                        }

                        dataGridView1.Rows[e.RowIndex].Cells["Favorite"].Value = "Favorite"; // Change button text
                    }
                    else
                    {
                        // Check if the friend is accepted before favoriting
                        if (dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Friend")
                        {
                            try
                            {
                                // Add to favorites
                                friendsManager.AddToFavorites(friendName, Session.Username);
                                MessageBox.Show($"{friendName} has been added to favorites.");
                                dataGridView1.Rows[e.RowIndex].Cells["Status"].Value = "Favorite"; // Update status
                                dataGridView1.Rows[e.RowIndex].Cells["Favorite"].Value = "Unfavorite"; // Change button text
                            }
                            catch (InvalidOperationException ex)
                            {
                                MessageBox.Show(ex.Message); // Show the error message if already a favorite
                            }
                        }
                        else
                        {
                            MessageBox.Show("You must accept the friend request before favoriting.");
                        }
                    }
                }
            }
        }



        private void btnTutup_Click(object sender, EventArgs e)
        {

            while (FormManager.Pop() != null) { }

            koneksi.Dispose();

            FormUtama mainForm = new FormUtama();
            mainForm.Show();


            this.Close();
        }
    }
}
