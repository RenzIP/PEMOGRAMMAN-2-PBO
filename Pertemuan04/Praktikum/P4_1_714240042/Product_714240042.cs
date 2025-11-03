using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240042
{
    public abstract class Product_714240042
    {
        private string myType;
        private string myTitle;

        protected Product_714240042() { }

        protected Product_714240042(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        // Konsistenkan nama properti
        public string MyType
        {
            get { return myType; }
            set { myType = value; }
        }

        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }

        public abstract void DisplayInfo();
    }
}
