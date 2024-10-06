using System;

namespace OOP
{
    internal class Book
    {
        private string _title;
        private string _author;

        public Book()
        {
            Console.WriteLine("Вызван конструктор по умолчанию класса Book");
            _title = "";
            _author = "";
        }
        public Book(string title, string author)
        {
            Console.WriteLine("Вызван конструктор с параметрами класса Book");
            _title = title;
            _author = author;
        }
        public Book(Book book)
        {
            Console.WriteLine("Вызван конструктор копирования класса Book");
            _title = book.GetTitle();
            _author = book.GetAuthor();
        }
        public void SetTitle(string title)
        {
            _title = title;
        }
        public void SetAuthor(string author)
        {
            _author = author;
        }
        public string GetTitle()
        {
            return _title;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public virtual void Show()
        {
            Console.WriteLine("Название книги: " + _title);
            Console.WriteLine("Автор книги: " + _author);
        }
    }
}
