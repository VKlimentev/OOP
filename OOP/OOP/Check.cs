using System;

namespace OOP
{
    static class Check
    {
        public static int InputInt(int MinValue, int MaxValue)
        {
            string input = Console.ReadLine();
            int output;
            if (int.TryParse(input, out output) && output >= MinValue && output <= MaxValue)
                return output;
            else
                return InputInt(MinValue, MaxValue);
        }
        public static string InputString(string message)
        {
            Console.WriteLine(message);
            string str = Console.ReadLine();
            if (str == "")
                return InputString(message);
            foreach (char letter in str)
                if (!char.IsLetter(letter))
                    return InputString(message);
            return str;
        }
        public static int InputPhone()
        {
            return int.Parse(InputCode() + InputNumber());
        }
        public static string InputCode()
        {
            Console.WriteLine("Введите код(25, 29, 33, 44)");
            string input = Console.ReadLine();
            if (input == "25" || input == "29" || input == "33" || input == "44")
                return input;
            else
                return InputCode();
        }
        public static string InputNumber()
        {
            int number;
            Console.WriteLine("Введите телефон(7 цифр): ");
            string phone = Console.ReadLine();

            if (!int.TryParse(phone, out number) || phone == "" || phone.Length != 7)
                return InputNumber();

            return number.ToString();
        }
    }
}
