using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_POS
{
    public class Komen
    {
        private int id;
        private string komentar;
        private DateTime tgl;
        private User username;
        private Konten kontenId;

        public Komen()
        {
            id = 0;
            komentar = "";
            username = new User();
            tgl = DateTime.Now;
            kontenId = new Konten();
        }

        public int Id { get => id; set => id = value; }
        public string Komentar { get => komentar; set => komentar = value; }
        public DateTime Tanggal { get => tgl; set => tgl = value; }
        public User Username { get => username; set => username = value; }
        public Konten KontenId { get => kontenId; set => kontenId = value; }

        public int GetLastInsertedId(Koneksi koneksi)
        {
            string query = "SELECT COALESCE(MAX(id), 0) FROM komen"; // Use COALESCE to return 0 if no records exist

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result); // Convert the result to an integer
            }
        }
        public void InsertKomen(Koneksi koneksi)
        {
           
            int lastId = GetLastInsertedId(koneksi);

            int newId = lastId + 1;

            string query = "INSERT INTO komen (id,komentar, tgl, username, Konten_id) VALUES (@id,@komentar, @tgl, @username, @kontenId)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("id", newId);
                cmd.Parameters.AddWithValue("@komentar", this.Komentar);
                cmd.Parameters.AddWithValue("@tgl", this.Tanggal);
                cmd.Parameters.AddWithValue("@username", this.Username.Username); // Assuming Username is a string property
                cmd.Parameters.AddWithValue("@kontenId", this.KontenId.Id); // Assuming KontenId has an Id property

                cmd.ExecuteNonQuery();
            }
        }

        public List<Komen> GetCommentsByKontenId(Koneksi koneksi, int kontenId)
        {
            List<Komen> comments = new List<Komen>();
            string query = "SELECT * FROM komen WHERE Konten_id = @kontenId";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@kontenId", kontenId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Komen comment = new Komen
                        {
                            Id = reader.GetInt32("id"),
                            Komentar = reader.GetString("komentar"),
                            Tanggal = reader.GetDateTime("tgl"),
                            Username = new User { Username = reader.GetString("username") },
                            KontenId = new Konten { Id = kontenId } // Assuming you want to link back to the content
                        };
                        comments.Add(comment);
                    }
                }
            }
            return comments;
        }
    }
}
