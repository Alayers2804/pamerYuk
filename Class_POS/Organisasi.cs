using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_POS
{
    public class Organisasi
    {
        private int id;
        private string namaOrganisasi;
        private Kota idKota;

        public Organisasi()
        {
            Id = 0;
            NamaOrganisasi = "";
            IdKota = new Kota(0, "");
        }

        public Organisasi(int id, string namaOrganisasi, Kota idKota)
        {
            Id = id;
            NamaOrganisasi = namaOrganisasi;
            IdKota = idKota;
        }

        public int Id { get => id; set => id = value; }
        public string NamaOrganisasi { get => namaOrganisasi; set => namaOrganisasi = value; }
        public Kota IdKota { get => idKota; set => idKota = value; }

        public void InsertOrganisasi(Koneksi koneksi)
        {
            string query = "INSERT INTO organisasi (id,nama, Kota_id) VALUES (@id, @nama, @kotaId)";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("id", this.Id);
                cmd.Parameters.AddWithValue("@nama", this.NamaOrganisasi);
                cmd.Parameters.AddWithValue("@kotaId", this.IdKota.Id); // Assuming IdKota has an Id property

                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetOrganizations(Koneksi koneksi)
        {
            List<string> organizations = new List<string>();
            string query = "SELECT nama FROM organisasi";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        organizations.Add(reader.GetString(0)); // Assuming the name is in the first column
                    }
                }
            }

            return organizations;
        }

        public List<string> GetOrganizations(int kotaId, Koneksi koneksi)
        {
            List<string> organizations = new List<string>();
            string query = "SELECT nama FROM organisasi WHERE Kota_id = @kotaId"; // Filter by Kota_id

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@kotaId", kotaId); // Add the parameter

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        organizations.Add(reader.GetString(0)); // Assuming the name is in the first column
                    }
                }
            }

            return organizations;
        }

        public int GetOrganizationIdByName(string organizationName, Koneksi koneksi)
        {
            int organizationId = -1; // Initialize to -1 (or any invalid ID)
            string query = "SELECT id FROM organisasi WHERE nama = @nama"; // Adjust the query based on your table structure

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@nama", organizationName);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Check if a record was found
                    {
                        organizationId = reader.GetInt32(0); // Assuming the ID is in the first column
                    }
                }
            }

            return organizationId; // Return the organization ID or -1 if not found
        }

        public string GetOrganizationNameById(int organizationId, Koneksi koneksi)
        {
            string organizationName = null; // Initialize to null
            string query = "SELECT nama FROM organisasi WHERE id = @organizationId";

            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.KoneksiDB))
            {
                cmd.Parameters.AddWithValue("@organizationId", organizationId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        organizationName = reader.GetString(0); // Get the organization name
                    }
                }
            }

            return organizationName; // Return the organization name or null if not found
        }


    }


}