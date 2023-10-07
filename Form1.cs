using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BookTips
{
    public partial class Form1 : Form
    {
        private List<Book> _books;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PickRandomBook();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _books = BookImporter.GetBooks();
            PickRandomBook();
        }

        private void PickRandomBook()
        {
            var previousBook = textBox1.Text;
            var book = GetRandomBook();

            while (previousBook == book.ToString())
            {
                book = GetRandomBook();
                
            }
            textBox1.Text = book.ToString();
        }

        public Book GetRandomBook()
        {
            var generateBooks = Random.Shared.Next(0, _books.Count);
            Book book = _books[generateBooks];
            return book;
        }
    }
}