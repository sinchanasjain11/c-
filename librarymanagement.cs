using System;

namespace LibraryManagement
{
    // Base class
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title  : {Title}");
            Console.WriteLine($"Author : {Author}");
        }
    }

    // Derived class
    class EBook : Book
    {
        public double FileSize { get; set; } // in MB
        public string Format { get; set; }   // e.g., PDF, EPUB, MOBI

        public EBook(string title, string author, double fileSize, string format)
            : base(title, author)
        {
            FileSize = fileSize;
            Format = format;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size : {FileSize} MB");
            Console.WriteLine($"Format    : {Format}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a normal book
            Book book1 = new Book("The Alchemist", "Paulo Coelho");
            Console.WriteLine("=== Printed Book ===");
            book1.DisplayInfo();

            Console.WriteLine();

            // Create an E-Book
            EBook ebook1 = new EBook("C# Programming Guide", "John Doe", 5.8, "PDF");
            Console.WriteLine("=== E-Book ===");
            ebook1.DisplayInfo();
        }
    }
}
