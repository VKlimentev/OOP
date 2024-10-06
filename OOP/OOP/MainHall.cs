using System;

namespace OOP
{
    internal class MainHall : Book
    {
        private DateTime _data;

        public MainHall() : base()
        {
            Console.WriteLine("Вызван конструктор по умолчанию класса MainHall");
            _data = DateTime.Parse(DateTime.Now.ToString().Remove(10));
        }
        public MainHall(string title, string author) : base(title, author)
        {
            Console.WriteLine("Вызван конструктор с параметрами класса MainHall");
            _data = DateTime.Parse(DateTime.Now.ToString().Remove(10));
        }
        public MainHall(MainHall book) : base(book)
        {
            Console.WriteLine("Вызван конструктор копирования класса MainHall");
            _data = book.GetData();
        }
        public DateTime GetData()
        {
            return _data;
        }
        public override void Show()
        {
            Console.WriteLine("\nНазвание книги: " + GetTitle());
            Console.WriteLine("Автор книги: " + GetAuthor());
            Console.WriteLine("Дата: " + _data);
        }
    }
}
