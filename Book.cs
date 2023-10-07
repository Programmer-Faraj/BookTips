using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTips
{
    public abstract class Book
    {
        public string Title;
        public string Author;
        public bool Availability;
        public string Type;

        protected Book(string title, string author, string type, bool availability)
        {
            Title = title;
            Author = author;
            Availability = availability;
            Type = type;
        }

        public override string ToString() 
        {
            return $"\"{Title}\" av {Author} ({Type})";
        }
    }
}
