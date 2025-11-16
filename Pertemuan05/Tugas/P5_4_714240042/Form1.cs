using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P5_4_714240042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Day1.Checked = false;
            Day2.Checked = false;
            Day3.Checked = false;
            Day4.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Football.Checked &&
                !Swim.Checked &&
                !Tenis.Checked &&
                !Yoga.Checked &&
                !Basket.Checked &&
                !Badminton.Checked &&
                !Volly.Checked &&
                !Archery.Checked)
            {
                MessageBox.Show(
                    "Harus memilih salah satu dari pilihan kelas",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!Day1.Checked &&
                !Day2.Checked &&
                !Day3.Checked &&
                !Day4.Checked)
            {
                MessageBox.Show(
                    "Harus memilih salah satu dari pilihan jadwal",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string nama = NamePlaceholder.Text;
            string jk = GenderChoose.Text;
            string tgl = DateSelect.Value.ToLongDateString();

            string kelas = "";

            if (Football.Checked) kelas += "Sepak Bola, ";
            if (Swim.Checked) kelas += "Renang, ";
            if (Tenis.Checked) kelas += "Tenis, ";
            if (Yoga.Checked) kelas += "Yoga, ";
            if (Basket.Checked) kelas += "Basket, ";
            if (Badminton.Checked) kelas += "Bulu Tangkis, ";
            if (Volly.Checked) kelas += "Voli, ";
            if (Archery.Checked) kelas += "Panahan, ";

            kelas = kelas.TrimEnd(' ', ',');

            // Jadwal
            string jadwal = "";

            if (Day1.Checked) jadwal = Day1.Text;
            if (Day2.Checked) jadwal = Day2.Text;
            if (Day3.Checked) jadwal = Day3.Text;
            if (Day4.Checked) jadwal = Day4.Text;

            // Tampilkan data
            string pesan =
                "Nama           : " + nama + "\n" +
                "Jenis Kelamin  : " + jk + "\n" +
                "Tanggal Lahir  : " + tgl + "\n" +
                "Pilihan Kelas  : " + kelas + "\n" +
                "Jadwal         : " + jadwal;

            MessageBox.Show(
                pesan,
                "Data Pendaftaran",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Day2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            Day1.Checked = false;
            Day2.Checked = false;
            Day3.Checked = false;
            Day4.Checked = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Paksa semua jadwal kosong setelah form tampil
            Day1.Checked = false;
            Day2.Checked = false;
            Day3.Checked = false;
            Day4.Checked = false;
        }

        private void GenderChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
