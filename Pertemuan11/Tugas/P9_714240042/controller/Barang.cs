using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240042.controller
{
    internal class Barang
    {
        private Koneksi koneksi = new Koneksi();

        public DataTable GetAll()
        {
            return (DataTable)koneksi.ShowData("SELECT id_barang AS ID, nama_barang AS `Nama Barang`, harga AS Harga FROM t_barang ORDER BY id_barang");
        }

        public DataTable Search(string keyword)
        {
            string sql = "SELECT id_barang AS ID, nama_barang AS `Nama Barang`, harga AS Harga FROM t_barang WHERE nama_barang LIKE @key ORDER BY id_barang";
            return (DataTable)koneksi.ShowDataParam(sql, new MySqlParameter("@key", "%" + keyword + "%"));
        }

        public void Insert(string nama, int harga)
        {
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("INSERT INTO t_barang (nama_barang, harga) VALUES (@nama, @harga)");
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@harga", harga);
                koneksi.ExecuteQuery(cmd);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        public void Update(int id, string nama, int harga)
        {
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("UPDATE t_barang SET nama_barang=@nama, harga=@harga WHERE id_barang=@id");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@harga", harga);
                koneksi.ExecuteQuery(cmd);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        public void Delete(int id)
        {
            try
            {
                koneksi.OpenConnection();
                var cmd = new MySqlCommand("DELETE FROM t_barang WHERE id_barang=@id");
                cmd.Parameters.AddWithValue("@id", id);
                koneksi.ExecuteQuery(cmd);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        public DataTable GetComboBarang()
        {
            return (DataTable)koneksi.ShowData("SELECT id_barang, nama_barang, harga FROM t_barang ORDER BY id_barang");
        }

        public DataRow GetBarangById(int idBarang)
        {
            string sql = "SELECT nama_barang, harga FROM t_barang WHERE id_barang=@id";
            DataTable dt = (DataTable)koneksi.ShowDataParam(sql, new MySqlParameter("@id", idBarang));
            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }
    }
}
