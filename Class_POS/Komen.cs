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

        public void InsertKomen(Koneksi koneksi)
        {
            string query = "INSERT INTO komen (komentar, tgl, username, kontenId) VALUES (@komentar, @tgl, @username, @kontenId)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@komentar", this.Komentar);
                cmd.Parameters.AddWithValue("@tgl", this.Tanggal);
                cmd.Parameters.AddWithValue("@username", this.Username.Username); // Assuming Username is a string property
                cmd.Parameters.AddWithValue("@kontenId", this.KontenId.Id); // Assuming KontenId has an Id property

                cmd.ExecuteNonQuery();
            }
        }
    }
}
