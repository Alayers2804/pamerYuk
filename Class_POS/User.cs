using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_POS
{
    public class User
    {
        private string username;
        private string password;
        private DateTime tglLahir;
        private string noKTP;
        private string foto;
        private Kota idKota;

        public User()
        {
            Username = "";
            Password = "";
            TglLahir = DateTime.Now;
            NoKTP = "";
            Foto = null;
            IdKota = new Kota(0, "");
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string NoKTP { get => noKTP; set => noKTP = value; }
        public string Foto { get => foto; set => foto = value; }
        public Kota IdKota { get => idKota; set => idKota = value; }

        public bool ValidateCredentials(string username, string password)
        {
            // Create a connection to the database
            using (Koneksi koneksi = new Koneksi())
            {
                // Prepare the SQL query to check for the user
                string query = "SELECT COUNT(*) FROM user WHERE username = @username AND password = @password";

                // Create a command to execute the query
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Consider hashing passwords in a real application

                    // Execute the command and get the result
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Return true if a user was found, otherwise false
                    return userCount > 0;
                }
            }
        }

        public void InsertUser(Koneksi koneksi)
        {
            string query = "INSERT INTO user (username, password, tglLahir, noKTP, foto, Kota_id) VALUES (@username, @password, @tglLahir, @noKTP, @foto, @kotaId)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", this.Username);
                cmd.Parameters.AddWithValue("@password", this.Password);
                cmd.Parameters.AddWithValue("@tglLahir", this.TglLahir);
                cmd.Parameters.AddWithValue("@noKTP", this.NoKTP);
                cmd.Parameters.AddWithValue("@foto", this.Foto);
                cmd.Parameters.AddWithValue("@kotaId", this.IdKota.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void InsertDescription(Koneksi koneksi, int organisasiId, string thawal, string thakhir, string deskripsi)
        {
            string query = "INSERT INTO kisahhidup (Organisasi_id, username, thawal, thakhir, deskripsi) VALUES (@Organisasi_id, @username, @thawal, @thakhir, @deskripsi)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@Organisasi_id", organisasiId);
                cmd.Parameters.AddWithValue("@username", this.Username);
                cmd.Parameters.AddWithValue("@thawal", thawal);
                cmd.Parameters.AddWithValue("@thakhir", thakhir);
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi);

                cmd.ExecuteNonQuery();
            }
        }

        public int GetKotaId(string username, Koneksi koneksi)
        {
            string query = "SELECT Kota_id FROM user WHERE username = @username";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", username); // Use the passed username
                object result = cmd.ExecuteScalar();

                // Return the Kota ID or 0 if not found
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        public int GetOrganisasiId(string username, Koneksi koneksi)
        {
            string query = "SELECT Organisasi_id FROM kisahhidup WHERE username = @username";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@username", username); // Use the passed username
                object result = cmd.ExecuteScalar();

                // Return the Organisasi ID or 0 if not found
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        public List<string> GetFriendsByCityAndOrganization(int kotaId, int organisasiId, Koneksi koneksi)
        {
            List<string> friends = new List<string>();
            string query = @"
        SELECT u.username 
        FROM user u
        JOIN kisahhidup k ON u.username = k.username 
        WHERE u.Kota_id = @kotaId AND k.Organisasi_id = @organisasiId 
        AND u.username <> @currentUsername";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@kotaId", kotaId);
                cmd.Parameters.AddWithValue("@organisasiId", organisasiId);
                cmd.Parameters.AddWithValue("@currentUsername", Session.Username); // Pass the current username
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        friends.Add(reader.GetString("username"));
                    }
                }
            }
            return friends;
        }



    }
}
