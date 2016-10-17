namespace Problem_02.Book_Shop
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }

    public class Book
    {
        private string author;
        private string title;
        private double price;

        public Book(string author, string title, double price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
               /* var names = value.Split();
                if (string.IsNullOrEmpty(value) || (names.Length >= 2 && names[1][0] >= '0' && names[1][0] <= '9'))
                {
                    throw new ArgumentException("Author not valid!");
                }*/
                /*if (string.IsNullOrEmpty(value) || Regex.IsMatch(value, "[A-Za-z]+\\s+\\d+[A-Za-z]*"))
                {
                    throw new ArgumentException("Author not valid!");
                }*/

                this.author = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length <= 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
                    .Append(Environment.NewLine)
                    .Append("Title: ").Append(this.Title)
                    .Append(Environment.NewLine)
                    .Append("Author: ").Append(this.Author)
                    .Append(Environment.NewLine)
                    .Append("Price: ").Append($"{this.Price:f1}")
                    .Append(Environment.NewLine);

            return sb.ToString();
        }
    }

    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, double price)
            : base(author, title, price)
        {
            
        }

        public override double Price => base.Price * 1.3;
    }
}
