using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Reader> readers = new List<Reader>();
            int choice, n = 0;
            do
            {
                Menu.MainMenu();
                choice = Check.InputInt(0, 8);
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        AddReader();
                        break;
                    case 2:
                        AddBook();
                        break;
                    case 3:
                        EditReader();
                        break;
                    case 4:
                        EditBook();
                        break;
                    case 5:
                        DeleteReader();
                        break;
                    case 6:
                        DeleteBook();
                        break;
                    case 7:
                        if (readers.Count == 0)
                        {
                            Console.WriteLine("В библиотеке не зарегистрировано ниодного читателя");
                            break;
                        }
                        foreach (Reader reader in readers)
                            reader.ShowBasicClass();
                        break;
                    case 8:
                        if (readers.Count == 0)
                        {
                            Console.WriteLine("В библиотеке не зарегистрировано ниодного читателя");
                            break;
                        }
                        foreach (Reader reader in readers)
                            reader.ShowSuccessorClass();
                        break;
                }
                n = 0;
                Console.ReadKey();
            } while (choice != 0);



            void AddReader()
            {
                string firstname = Check.InputString("Введите имя читателя");

                string lastname = Check.InputString("Введите фамилию читателя");

                int phone = Check.InputPhone();

                readers.Add(new Reader(firstname, lastname, phone));
                Console.WriteLine("Читатель успешно добавлен");
            }
            void EditReader()
            {
                if (readers.Count == 0)
                {
                    Console.WriteLine("В библиотеке не зарегистрировано ниодного читателя");
                    return;
                }

                foreach (Reader reader in readers)
                    reader.ShowReader(ref n);

                Console.WriteLine("Введите номер читателя для редактирования");
                choice = Check.InputInt(1, readers.Count);

                readers[choice - 1].EditReader();
            }
            void DeleteReader()
            {
                if (readers.Count == 0)
                {
                    Console.WriteLine("В библиотеке не зарегистрировано ниодного читателя");
                    return;
                }

                foreach (Reader reader in readers)
                    reader.ShowReader(ref n);

                Console.WriteLine("Введите номер читателя для удаления");
                choice = Check.InputInt(1, readers.Count);

                readers.RemoveAt(choice - 1);
                Console.WriteLine("Читатель успешно удален");
            }



            void AddBook()
            {
                if (readers.Count == 0)
                {
                    Console.WriteLine("В библиотеке не зарегистрировано ниодного читателя");
                    return;
                }

                foreach (Reader reader in readers)
                    reader.ShowReader(ref n);

                Console.WriteLine("Введите номер читателя для добавления книги");
                choice = Check.InputInt(1, readers.Count);

                readers[choice - 1].AddBook();
            }
            void EditBook()
            {
                if (readers.Count == 0)
                {
                    Console.WriteLine("В библиотеке не зарегистрировано ниодного читателя");
                    return;
                }

                foreach (Reader reader in readers)
                    reader.ShowBooks(ref n);

                Console.WriteLine("Введите номер книги для редактирования");
                n = Check.InputInt(1, n);

                foreach (Reader reader in readers)
                    reader.EditBook(ref n);
            }
            void DeleteBook()
            {
                if (readers.Count == 0)
                {
                    Console.WriteLine("В библиотеке не зарегистрировано ниодного читателя");
                    return;
                }

                foreach (Reader reader in readers)
                    reader.ShowBooks(ref n);

                Console.WriteLine("Введите номер книги для удаления");
                n = Check.InputInt(1, n);

                foreach (Reader reader in readers)
                    reader.DeleteBook(ref n);
            }
        }
    }
}
