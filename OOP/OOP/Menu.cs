using System;

namespace OOP
{
    static class Menu
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Что хотите сделать?\n" +
                              "1 - Добавить читателя\n" +
                              "2 - Добавить книгу\n" +
                              "3 - Редактировать информацию о читателе\n" +
                              "4 - Редактировать информацию о книге\n" +
                              "5 - Удалить читателя\n" +
                              "6 - Удалить книгу\n" +
                              "7 - Вывести информацию о читателях базового класса\n" +
                              "8 - Вывести информацию о читателях классов-наследников\n" +
                              "0 - Выход");
            Console.Write(">");
        }
        public static void SelectClass()
        {
            Console.WriteLine("1 - Добавить в базовый класс\n" +
                              "2 - Добавить в класс наследник\n" +
                              "0 - Вернуться в главное меню");
            Console.Write(">");
        }
        public static void EditReader()
        {
            Console.Clear();
            Console.WriteLine("Что хотите изменить?\n" +
                              "1 - Имя\n" +
                              "2 - Фамилия\n" +
                              "3 - Телефон\n" +
                              "0 - Вернуться в главное меню");
            Console.Write(">");
        }
        public static void EditBook()
        {
            Console.Clear();
            Console.WriteLine("Что хотите изменить?\n" +
                              "1 - Название книги\n" +
                              "2 - Автора книги\n" +
                              "0 - Вернуться в главное меню");
            Console.Write(">");
        }
    }
}
