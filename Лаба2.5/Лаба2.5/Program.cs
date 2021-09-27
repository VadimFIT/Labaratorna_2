using System;

namespace Лаба2._5
{
    class User
    {
        public static string log;
        public static string name;
        public static string surname;
        public static int age;
        private static string data;
        public User(string data)
        {
            Console.WriteLine("Введіть логін: ");
            log = Console.ReadLine();
            Console.WriteLine("Введіть ім'я: ");
            name = Console.ReadLine();
            Console.WriteLine("Введіть прізвище: ");
            surname = Console.ReadLine();
            Console.WriteLine("Введіть ваш вік: ");
            age = Convert.ToInt32(Console.ReadLine());
            User.data = data;
        }
        public static void Show()
        {
            Console.WriteLine("Логін: " + log);
            Console.WriteLine("Ім'я: " + name);
            Console.WriteLine("Прізвище: " + surname);
            Console.WriteLine("Вік: " + age);
            Console.WriteLine("Дата: " + data);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть дату: ");
            string data = Console.ReadLine();
            User new_person = new User(data);
            User.Show();
            Console.ReadLine();
        }
    }
}
