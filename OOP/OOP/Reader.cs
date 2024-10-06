using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Reader
    {
        private string _firstname;
        private string _lastname;
        private int _phone;
        private List<Book> _books;
        private List<ReadingRoom> _readingRoom;
        private List<MainHall> _mainHall;

        public Reader(string firstname, string lastname, int phone)
        {
            _firstname = firstname;
            _lastname = lastname;
            _phone = phone;
            _books = new List<Book>();
            _readingRoom = new List<ReadingRoom>();
            _mainHall = new List<MainHall>();
        }
        public void AddBook()
        {
            string title = Check.InputString("Введите название книги");

            string author = Check.InputString("Введите автора книги");

            Menu.SelectClass();
            int choice = Check.InputInt(0, 2);

            switch (choice)
            {
                case 1:
                    _books.Add(new Book(title, author));
                    _books.Add((Book)new ReadingRoom(title, author, _firstname, _lastname));
                    _books.Add((Book)new MainHall(title, author));
                    break;
                case 2:
                    _readingRoom.Add(new ReadingRoom(title, author, _firstname, _lastname));
                    _mainHall.Add(new MainHall(title, author));
                    break;
            }

            Console.WriteLine("Книга успешно добавлена");
        }
        public void EditReader()
        {
            Menu.EditReader();
            int choice = Check.InputInt(0, 3);
            switch (choice)
            {
                case 1:
                    _firstname = Check.InputString("Введите новое имя");
                    Console.WriteLine("Имя успешно изменено");
                    break;

                case 2:
                    _lastname = Check.InputString("Введите новую фамилию");
                    Console.WriteLine("Фамилия успешно изменено");
                    break;

                case 3:
                    Console.WriteLine("Введите новый телефон");
                    _phone = Check.InputPhone();
                    Console.WriteLine("Телефон успешно изменен");
                    break;
            }
        }
        public void EditBook(ref int n)
        {
            int i;
            for (i = 0; i < _books.Count; i++, n--)
            {
                if (n > 1)
                    continue;
                break;
            }
            Menu.EditBook();
            int choice = Check.InputInt(0, 2);
            switch (choice)
            {
                case 1:
                    _books[i].SetTitle(Check.InputString("Введите новое название"));
                    Console.WriteLine("Название успешно изменено");
                    break;

                case 2:
                    _books[i].SetAuthor(Check.InputString("Введите нового автора"));
                    Console.WriteLine("Автор успешно изменен");
                    break;
            }
        }
        public void DeleteBook(ref int n)
        {
            int i;
            for (i = 0; i < _books.Count; i++, n--)
            {
                if (n > 1)
                    continue;
                break;
            }
            _books.RemoveAt(i);
            Console.WriteLine("Книга успешно удалена");
        }
        public void ShowBasicClass()
        {
            Console.WriteLine("Читатель: " + _lastname + ' ' + _firstname);
            Console.WriteLine("Телефон: +375" + _phone);
            foreach (Book book in _books)
                book.Show();
        }
        public void ShowSuccessorClass()
        {
            Console.WriteLine("Читатель: " + _lastname + ' ' + _firstname);
            Console.WriteLine("Телефон: +375" + _phone);
            Console.WriteLine("\nОснвной зал");
            foreach (MainHall hall in _mainHall)
                hall.Show();
            Console.WriteLine("\nЧитальный зал");
            foreach (ReadingRoom reading in _readingRoom)
                reading.Show();
        }
        public void ShowBooks(ref int n)
        {
            Console.WriteLine("Читатель: " + _lastname + ' ' + _firstname);
            Console.WriteLine("Телефон: +375 " + _phone);
            foreach (Book book in _books)
            {
                Console.WriteLine("\nКнига №" + ++n);
                book.Show();
            }
        }
        public void ShowReader(ref int n)
        {
            Console.WriteLine("Читатель №" + ++n);
            Console.WriteLine(_lastname + ' ' + _firstname);
        }
    }
}
