using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1.Repository
{
    internal class FarmRepository
    {
        private readonly string _connectionString;

        public FarmRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
        }

        public void Save(string type, int amount)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Animal (AnimalType, Amount) VALUES (@animalType, @amount)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@animalType", type);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAnimalList()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Animal";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public void Update(string type, int newAmount)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Animal SET Amount = @amount WHERE AnimalType = @animalType";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@amount", newAmount);
                    cmd.Parameters.AddWithValue("@animalType", type);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

