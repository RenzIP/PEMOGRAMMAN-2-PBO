using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240042.model
{
    internal class M_transaksi
    {
        public int IdTransaksi { get; set; }
        public int IdBarang { get; set; }
        public string NamaBarang { get; set; } = "";
        public int Harga { get; set; }
        public int Qty { get; set; }
        public int Total { get; set; }

    }
}
