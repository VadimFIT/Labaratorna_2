using System;

namespace Лаба2._7
{
    class Employee
    {
        private static string Input;
        public static string Name;
        public static string Surname;
        public static double Experience;
        public static double Nalog;
        public static double Oklad;
        
        public Employee()
        {
            Console.WriteLine("Введіть ваше ім'я: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть ваше прізвище: ");
            Surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть досвід роботи: ");
            Experience = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Виберіть посаду: ");
            Console.WriteLine("Введіть '1' - Головний маркетолог");
            Console.WriteLine("Введіть '2' - Менеджер по продажам"); 
            Console.WriteLine("Введіть '3' - Помічник маркетолога");
            Input = Convert.ToString(Console.ReadLine());
            Employee.Calculator();
        }
        public static void Calculator()
        {
            if (Input == "1")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Прізвище: " + Surname);
                Console.WriteLine("Посада: Головний маркетолог");
                Nalog = 30000 * 0.2 / Experience;
                Oklad = 30000 - Nalog;
                Console.WriteLine("Налог: " + Nalog);
                Console.WriteLine("Оклад: " + Oklad);
            }
            else if (Input == "2")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Прізвище: " + Surname);
                Console.WriteLine("Посада: Менеджер по продажам");
                Nalog = 20000 * 0.2 / Experience;
                Oklad = 20000 - Nalog;
                Console.WriteLine("Налог: " + Nalog);
                Console.WriteLine("Оклад: " + Oklad);
            }
            else if (Input == "3")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Прізвище: " + Surname);
                Console.WriteLine("Посада: Помічник маркетолога");
                Nalog = 10000 * 0.2 / Experience;
                Oklad = 10000 - Nalog;
                Console.WriteLine("Налог: " + Nalog);
                Console.WriteLine("Оклад: " + Oklad);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Employee new_employee = new Employee();
            Console.ReadLine();
        }
    }
}
