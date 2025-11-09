using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240042
{
    public class MemeLucu : Meme
    {
        public MemeLucu(string type, string caption) : base(type, caption)
        {
            Console.WriteLine("Dari class MemeLucu");
        }

        // POLYMORPHISM
        public override void DisplayInfo()
        {
            Console.WriteLine("{0}: \"{1}\" WKWKWK", Type, Caption);
        }
    }
}
