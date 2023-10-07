using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTips
{
    internal class Magazine : Book
    {
        public Magazine(string title, string author, bool availability) : base(title, author, "Magazine", availability)
        {
            
        }
     
    }
}
