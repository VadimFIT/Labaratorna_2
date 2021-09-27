using System;

namespace ЛАБА2
{
    class Adress
    {
        private static int index;
        public static int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        private static string country;
        public static string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private static string city;
        public static string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private static string street;
        public static string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private static int house;
        public static int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        private static int apartment;
        public static int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
        public static void Show()
        {
            Console.WriteLine("Індекс: " + index);
            Console.WriteLine("Країна: " + country);
            Console.WriteLine("Місто: " + city);
            Console.WriteLine("Вулиця: " + street);
            Console.WriteLine("Дім: " + house);
            Console.WriteLine("Номер апартаментів: " + apartment);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть індекс: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Adress.Index = index;
            Console.WriteLine("Введіть країну: ");
            string country = Console.ReadLine();
            Adress.Country = country;
            Console.WriteLine("Введіть місто: ");
            string city = Console.ReadLine();
            Adress.City = city;
            Console.WriteLine("Введіть вулицю: ");
            string street = Console.ReadLine();
            Adress.Street = street;
            Console.WriteLine("Введіть дім: ");
            int house = Convert.ToInt32(Console.ReadLine());
            Adress.House = house;
            Console.WriteLine("Введіть номер апартаментів: ");
            int apartment = Convert.ToInt32(Console.ReadLine());
            Adress.Apartment = apartment;
            Adress.Show();
            Console.ReadLine();
        }
    }
}
