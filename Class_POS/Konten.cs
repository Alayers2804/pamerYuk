using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_POS
{
    public class Konten
    {
        private int id;
        private string caption;
        private string foto;
        private string video;
        private DateTime tglUpload;
        private User username;

        public Konten()
        {
            Id = 0;
            Caption = "";
            Foto = "";
            Video = "";
            TglUpload = DateTime.Now;
            User = new User();
        }

        public int Id { get => id; set => id = value; }
        public string Caption { get => caption; set => caption = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Video { get => video; set => video = value; }
        public DateTime TglUpload { get => tglUpload; set => tglUpload = value; }
        public User User { get => username; set => username = value; }

        public int GetLastInsertedId(Koneksi koneksi)
        {
            string query = "SELECT COALESCE(MAX(id), 0) FROM konten"; // Use COALESCE to return 0 if no records exist

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result); // Convert the result to an integer
            }
        }
        public int InsertKonten(Koneksi koneksi)
        {
            // Get the last inserted ID from the database
            int lastId = GetLastInsertedId(koneksi);

            // Increment the ID for the new record
            int newId = lastId + 1;

            // Prepare the insert query
            string query = "INSERT INTO konten (id, caption, foto, video, tglUpload, username) VALUES (@id, @caption, @foto, @video, @tglUpload, @username)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@id", newId); // Use the new ID
                cmd.Parameters.AddWithValue("@caption", this.Caption);
                cmd.Parameters.AddWithValue("@foto", this.Foto);
                cmd.Parameters.AddWithValue("@video", this.Video);
                cmd.Parameters.AddWithValue("@tglUpload", this.TglUpload);
                cmd.Parameters.AddWithValue("@username", User.Username);

                // Execute the insert command
                cmd.ExecuteNonQuery();
            }

            return newId; // Return the new ID
        }

        public List<Konten> GetAllKonten(Koneksi koneksi)
        {
            List<Konten> kontenList = new List<Konten>();
            string query = "SELECT * FROM konten"; // Adjust the query as needed

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Konten konten = new Konten
                        {
                            Id = reader.GetInt32("id"),
                            Caption = reader.GetString("caption"),
                            Foto = reader.GetString("foto"),
                            Video = reader.GetString("video"),
                            TglUpload = reader.GetDateTime("tglUpload"),
                            User = new User { Username = reader.GetString("username") } // Assuming username is a string
                        };
                        kontenList.Add(konten);
                    }
                }
            }
            return kontenList;
        }

        public void InsertTag(Koneksi koneksi, int id, string tagName)
        {
            string query = "INSERT INTO tag (konten_id, username) VALUES (@konten_id, @username)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@konten_id", id); // Use the ID of the newly created Konten
                cmd.Parameters.AddWithValue("@username", tagName);
                
                cmd.ExecuteNonQuery(); // Execute the insert command
            }
        }

        public List<string> GetTaggedUsers(Koneksi koneksi)
        {
            List<string> taggedUsers = new List<string>();
            string query = "SELECT username FROM tag WHERE konten_id = @konten_id";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@konten_id", this.Id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        taggedUsers.Add(reader.GetString("username"));
                    }
                }
            }
            return taggedUsers;
        }

    }

}
