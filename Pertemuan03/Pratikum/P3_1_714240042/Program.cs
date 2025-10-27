using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714240042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("MENENTUKAN INDEKS PRESTASI MAHASISWA\n----------------------------------");
                Console.Write("\nMasukkan Nama Mahasiswa: ");

                string nama = Console.ReadLine();

                Console.WriteLine("Masukan Nilai: ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Masukkan Nilai Mahasiswa: ");

                string[] grade = { "A", "B", "C", "D", "E" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                { 
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.Write("\nMasukan indeks yang ditampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks prestasi {0} adalah ", nama);

                prestasi(indeks);

                Console.Write("\nIngin Mengulang Kembali (Y/T)? ");
            }

            while (Console.ReadLine() == "Y");
        }

        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("Sangat Baik");
                    break;
                case 'B':
                    Console.WriteLine("Baik");
                    break;
                case 'C':
                    Console.WriteLine("cukup");
                    break;
                case 'D':
                    Console.WriteLine("buruk");
                    break;
                default:
                    Console.WriteLine("Invalid indeks prestasi");
                    break;
            }
        }
    }
}
