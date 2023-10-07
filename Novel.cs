using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTips
{
    internal class Novel : Book
    {
        public Novel(string title, string author, bool availability) : base(title, author, "Roman", availability)
        {

        }
    }
}
