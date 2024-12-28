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
            // Check if the friend request exists
            string checkQuery = "SELECT COUNT(*) FROM teman WHERE username1 = @requester AND username2 = @requestee AND status = 'pending'";
            using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, koneksi.KoneksiDB))
            {
                checkCmd.Parameters.AddWithValue("@requester", requester);
                checkCmd.Parameters.AddWithValue("@requestee", requestee);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count == 0)
                {
                    throw new InvalidOperationException("No pending friend request found between the users.");
                }
            }

            // Update the status of the friend request to 'accepted'
            string updateQuery = "UPDATE teman SET status = 'accepted', tglBerteman = NOW() WHERE username1 = @requester AND username2 = @requestee";
            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, koneksi.KoneksiDB))
            {
                updateCmd.Parameters.AddWithValue("@requester", requester);
                updateCmd.Parameters.AddWithValue("@requestee", requestee);
                updateCmd.ExecuteNonQuery();
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

        public List<(string requester, string status)> GetPendingRequests(string username)
        {
            List<(string requester, string status)> pendingRequests = new List<(string, string)>();
            string query = "SELECT username1, status FROM teman WHERE username2 = @username AND status = 'pending'";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pendingRequests.Add((reader.GetString("username1"), reader.GetString("status")));
                    }
                }
            }
            return pendingRequests;
        }

        public void AddToFavorites(string friendUsername, string currentUsername)
        {
            // Check if the friend is already in favorites
            if (IsFavorited(friendUsername, currentUsername))
            {
                throw new InvalidOperationException("This user is already in your favorites.");
            }

            string query = "INSERT INTO favorite_friends (username, favorite_username) VALUES (@username, @favorite_username)";
            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", currentUsername);
                cmd.Parameters.AddWithValue("@favorite_username", friendUsername);
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveFromFavorites(string friendUsername, string currentUsername)
        {
            string query = "DELETE FROM favorite_friends WHERE username = @username AND favorite_username = @favorite_username";
            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", currentUsername);
                cmd.Parameters.AddWithValue("@favorite_username", friendUsername);
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetFavoriteFriends(string username)
        {
            List<string> favoriteFriends = new List<string>();
            string query = "SELECT favorite_username FROM favorite_friends WHERE username = @username";
            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        favoriteFriends.Add(reader.GetString("favorite_username"));
                    }
                }
            }
            return favoriteFriends;
        }

        public bool IsAlreadyFriends(string friendUsername, string currentUsername)
        {
            // Update the query to check only for accepted friendships
            string query = "SELECT COUNT(*) FROM teman WHERE ((username1 = @username AND username2 = @friendUsername) OR (username1 = @friendUsername AND username2 = @username)) AND status = 'accepted'";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", currentUsername);
                cmd.Parameters.AddWithValue("@friendUsername", friendUsername);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // Return true if already friends (accepted)
            }
        }


        public bool IsFavorited(string friendUsername, string currentUsername)
        {
            string query = "SELECT COUNT(*) FROM favorite_friends WHERE username = @username AND favorite_username = @friendUsername";
            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", currentUsername);
                cmd.Parameters.AddWithValue("@friendUsername", friendUsername);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // Return true if the friend is already favorited
            }
        }


    }
}
