using System;

namespace OOP
{
    internal class ReadingRoom : Book
    {
        private string _firstname;
        private string _lastname;
        public ReadingRoom() : base()
        {
            Console.WriteLine("Вызван конструктор по умолчанию класса ReadingRoom");
            _firstname = "";
            _lastname = "";
        }
        public ReadingRoom(string title, string author, string firstname, string lastname) : base(title, author)
        {
            Console.WriteLine("Вызван конструктор с параметрами класса ReadingRoom");
            _firstname = firstname;
            _lastname = lastname;
        }
        public ReadingRoom(ReadingRoom book) : base(book)
        {
            Console.WriteLine("Вызван конструктор копирования класса MainHall");
            _firstname = book._firstname;
            _lastname = book._lastname;
        }
        public override void Show()
        {
            Console.WriteLine("\nНазвание книги: " + GetTitle());
            Console.WriteLine("Автор книги: " + GetAuthor());
            Console.WriteLine("Имя: " + _firstname);
            Console.WriteLine("Фамилия: " + _lastname);
        }
    }
}
