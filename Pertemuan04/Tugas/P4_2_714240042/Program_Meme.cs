using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240042
{
    internal class Program_Meme
    {
        static void Main(string[] args)
        {
            MemeLucu meme1 = new MemeLucu("Meme Lucu", "Ketika koding jalan, tapi hasilnya bukan yang dimaksud");
            MemeBaper meme2 = new MemeBaper("Meme Baper", "Dia bilang 'good luck', tapi bukan buat aku");

            meme1.DisplayInfo();
            meme2.DisplayInfo();
        }
    }
}
