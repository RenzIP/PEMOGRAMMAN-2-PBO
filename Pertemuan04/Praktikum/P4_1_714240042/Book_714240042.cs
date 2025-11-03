using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240042
{
    public class Book_714240042 : Product_714240042
    {
        protected string pageCount;

        public Book_714240042(string type, string title, string pageCount) : base(type, title)
        {
            this.PageCount = pageCount;
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} calles \"{1}\" and has {2} page", MyType, MyTitle, PageCount ); 
        }
    }
}
