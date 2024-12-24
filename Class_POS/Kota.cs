using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_POS
{
    public class Kota
    {
        private int id;
        private string namaKota;
        public Kota()
        {
            Id = 0;
            NamaKota = "";
        }

        public Kota(int id, string namaKota)
        {
            Id = id;
            NamaKota = namaKota;
        }

        public int Id { get => id; set => id = value; }
        public string NamaKota { get => namaKota; set => namaKota = value; }

        public List<string> GetCity(Koneksi koneksi)
        {
            List<string> cities = new List<string>();
            string query = "SELECT nama FROM kota";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cities.Add(reader.GetString(0)); // Assuming the name is in the first column
                        }
                    }
                
            }

            return cities;
        }
        public int GetCityIdByName(string cityName, Koneksi koneksi)
        {
            int cityId = -1; 
            string query = "SELECT id FROM kota WHERE nama = @cityName"; 

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@cityName", cityName);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cityId = reader.GetInt32(0);
                    }
                }
            }

            return cityId;        
        }

        public void InsertKota(Koneksi koneksi)
        {
            string query = "INSERT INTO kota (id,nama) VALUES (@id,@nama)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@id", this.Id);
                cmd.Parameters.AddWithValue("@nama", this.NamaKota); // Assuming you want to insert the city name

                cmd.ExecuteNonQuery();
            }
        }

        public string GetCityNameById(int cityId, Koneksi koneksi)
        {
            string cityName = null; // Initialize to null
            string query = "SELECT nama FROM kota WHERE id = @cityId";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@cityId", cityId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cityName = reader.GetString(0); // Get the city name
                    }
                }
            }

            return cityName; // Return the city name or null if not found
        }

    }
}

