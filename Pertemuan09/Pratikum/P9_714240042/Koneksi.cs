using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240042
{
    internal class Koneksi
    {
        string connectionString = "Server=139.59.111.220;Database=pemrog2ulbi;Uid=gasba;Pwd=-Kampret321";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionString);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public object ShowData(string query)
        {
            var table = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var adapter = new MySqlDataAdapter(query, conn))
                {
                    adapter.Fill(table);
                }
            }
            return table;
        }
    }
}
