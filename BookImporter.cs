using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace BookTips
    {

    internal static class  BookImporter
    {

        public static List<Book> GetBooks()
        {
            List<Book> bookList = new List<Book>();
            try
            {
                var filePath = Path.Combine(@"C:\Users\moham", @"Downloads\tips_texter.txt");

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath, Encoding.Default, true))
                    {
                        while (reader.ReadLine() is string item)
                        {
                            string[] bookParts = item.Split("###", StringSplitOptions.RemoveEmptyEntries);
                            if (bookParts.Length != 4) continue;

                            string title = bookParts[0];
                            string author = bookParts[1];
                            string type = bookParts[2];
                            bool.TryParse(bookParts[3], out bool availability);

                            Book tempBook = ConvertToBook(type: type, Author: author, Title: title, available: availability);
                            bookList.Add(tempBook);
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        return bookList;   
        }  
        
        // This method is converting from a string line to a book object and specifies the type of book 
        public static Book ConvertToBook(string type, string Title, string Author, bool available)
        {
            switch (type)
            {
                case "Roman": // Roman
                    return new Novel(Title, Author, available);
                case "Tidskrift": // Tidskrift
                    return new Magazine(Title, Author, available);
                case "Novellsamling":
                    return new ShortStoryCollection(Title, Author, available);
                default:
                    throw new ArgumentOutOfRangeException("Invalid book type!");
            }
        }
    }
    }

