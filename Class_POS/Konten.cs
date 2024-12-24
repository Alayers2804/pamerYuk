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
            Username = new User();
        }

        public int Id { get => id; set => id = value; }
        public string Caption { get => caption; set => caption = value; }
        public string Foto { get => foto; set => foto = value; }
        public string Video { get => video; set => video = value; }
        public DateTime TglUpload { get => tglUpload; set => tglUpload = value; }
        public User Username { get => username; set => username = value; }

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
                cmd.Parameters.AddWithValue("@username", this.Username.Username);

                // Execute the insert command
                cmd.ExecuteNonQuery();
            }

            return newId; // Return the new ID
        }
    }

}
