using System;

namespace Лаба2._8
{
    class Invoice
    {
        int account;
        string customer;
        string provider;
        private string article;
        private static int quantity;
        public static double cost;
        public static double price;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public Invoice(string good, int quantity, double price)
        {
            Invoice.quantity = quantity;
            Invoice.price = price;
            Invoice.WithHDC();
            Invoice.NoHDC();
        }
        public static void WithHDC()
        {
            cost = quantity * price * 0.8;
            Console.WriteLine("Сума платежу зі НДС товару: " + cost);
        }
        public static void NoHDC()
        {
            cost = quantity * price;
            Console.WriteLine("Сума платежу без НДС товару: " + cost);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Назва товару який будете замовляти: ");
            string good = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Кількість товару: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ціна товару: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Invoice Person = new Invoice(343434, "Ольга", "Володимиру");
            Invoice Item = new Invoice(good, quantity, price);
        }
    }
}
