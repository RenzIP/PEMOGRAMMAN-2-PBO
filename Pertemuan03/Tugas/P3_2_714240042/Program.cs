using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangi;

            do
            {
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                int pilihan = Convert.ToInt32(Console.ReadLine());

                if (pilihan == 3)
                {
                    Console.WriteLine("Program selesai.");
                    Console.WriteLine("Terima kasih!");
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadKey();
                    break;
                }
                else if (pilihan == 1 || pilihan == 2)
                {
                    Console.Write("Masukkan panjang: ");
                    int panjang = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Masukkan lebar: ");
                    int lebar = Convert.ToInt32(Console.ReadLine());

                    prosesPerhitungan(pilihan, panjang, lebar);

                    Console.Write("Ingin mengulang kembali (Y/T)? ");
                    ulangi = Console.ReadLine().ToUpper();

                    if (ulangi == "T")
                    {
                        Console.WriteLine("Terima kasih!");
                        Console.WriteLine("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                    Console.Write("Ingin mengulang kembali (Y/T)? ");
                    ulangi = Console.ReadLine().ToUpper();

                    if (ulangi == "T")
                    {
                        Console.WriteLine("Terima kasih!");
                        Console.WriteLine("Press any key to continue . . .");
                        Console.ReadKey();
                        break;
                    }
                }

            } while (true);
        }

        // @Rhoterox
        private static void prosesPerhitungan(int pilihan, int panjang, int lebar)
        {
            int luas = panjang * lebar;
            int keliling = 2 * (panjang + lebar);

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Luas Persegi Panjang: " + luas);
                    break;

                case 2:
                    Console.WriteLine("Keliling Persegi Panjang: " + keliling);
                    break;
            }
        }
    }
}
