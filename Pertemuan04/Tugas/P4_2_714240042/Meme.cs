using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240042
{
    public abstract class Meme
    {
        private string type;
        private string caption;

        protected Meme() { }

        protected Meme(string type, string caption)
        {
            this.type = type;
            this.caption = caption;
        }

        // ENCAPSULATION
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        // ABSTRACTION
        public abstract void DisplayInfo();
    }
}
