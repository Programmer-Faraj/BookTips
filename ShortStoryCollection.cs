using BookTips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTips
{
    internal class ShortStoryCollection : Book
    {
        public ShortStoryCollection(string title, string author, bool availability) : base(title, author, "Novellsamling", availability)
        {

        }
    }
}