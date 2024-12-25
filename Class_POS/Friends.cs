using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Class_POS
{
    public class Friends
    {
        private Koneksi koneksi;

        public Friends(Koneksi koneksi)
        {
            this.koneksi = koneksi;
        }

        public void SendFriendRequest(string requester, string requestee)
        {
            if (koneksi.KoneksiDB.State != ConnectionState.Open)
            {
                MessageBox.Show("Database connection is not open.");
                return;
            }

            // Prevent sending a request to oneself
            if (requester.Equals(requestee, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot send a friend request to yourself.");
                return;
            }

            // Check if a friend request already exists
            string checkQuery = "SELECT COUNT(*) FROM teman WHERE (username1 = @requester AND username2 = @requestee) OR (username1 = @requestee AND username2 = @requester)";
            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, koneksi.KoneksiDB))
            {
                checkCmd.Parameters.AddWithValue("@requester", requester);
                checkCmd.Parameters.AddWithValue("@requestee", requestee);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Friend request already exists.");
                    return;
                }
            }

            // Insert the friend request
            string query = "INSERT INTO teman (username1, username2, tglBerteman, status) VALUES (@requester, @requestee, NOW(), 'pending')";
            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@requester", requester);
                cmd.Parameters.AddWithValue("@requestee", requestee);
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Friend request sent to {requestee}.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to send friend request.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending friend request: " + ex.Message);
                }
            }
        }



        public void AcceptFriendRequest(string requester, string requestee)
        {
            string query = "UPDATE teman SET status = 'accepted', tglBerteman = NOW() WHERE username1 = @requester AND username2 = @requestee";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@requester", requester);
                cmd.Parameters.AddWithValue("@requestee", requestee);
                cmd.ExecuteNonQuery();
            }
        }

        public void RejectFriendRequest(string requester, string requestee)
        {
            string query = "DELETE FROM teman WHERE username1 = @requester AND username2 = @requestee";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@requester", requester);
                cmd.Parameters.AddWithValue("@requestee", requestee);
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetFriends(string username)
        {
            List<string> friends = new List<string>();
            string query = "SELECT username1 AS friend FROM teman WHERE username2 = @username AND status = 'accepted' " +
                           "UNION " +
                           "SELECT username2 AS friend FROM teman WHERE username1 = @username AND status = 'accepted'";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        friends.Add(reader.GetString("friend"));
                    }
                }
            }
            return friends;
        }

        public List<string> GetPendingRequests(string username)
        {
            List<string> pendingRequests = new List<string>();
            string query = "SELECT username1 FROM teman WHERE username2 = @username AND status = 'pending'";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pendingRequests.Add(reader.GetString("username1"));
                    }
                }
            }
            return pendingRequests;
        }
    }
}
