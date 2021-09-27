using System;

namespace Лаба2._6
{
    class Converter
    {
        private static double Input;
        private static string InputNumber;
        private static double Output;
        public Converter(double usd, double eur, double rub)
        {
            Console.WriteLine("Оберіть з якої валюти в яку буде відбуватися конвертація");
            Console.WriteLine("Введіть '1' для конвертації гривень в долари ");
            Console.WriteLine("Введіть '2' для конвертації гривень в євро ");
            Console.WriteLine("Введіть '3' для конвертації гривень в рублі ");
            Console.WriteLine("Введіть '4' для конвертації доларів в гривні ");
            Console.WriteLine("Введіть '5' для конвертації євро в гривні ");
            Console.WriteLine("Введіть '6' для конвертації рублів в гривні ");
            InputNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Кількість валюти, що конвертується: ");
            Input = Convert.ToDouble(Console.ReadLine());
            if (InputNumber == "1")
            {
                Output = Input / usd;
                Console.WriteLine(Output + " доларів");
            }
            else if (InputNumber == "2")
            {
                Output = Input / eur;
                Console.WriteLine(Output + " євро");
            }
            else if (InputNumber == "3")
            {
                Output = Input / rub;
                Console.WriteLine(Output + " рублів");
            }
            else if (InputNumber == "4")
            {
                Output = Input * usd;
                Console.WriteLine(Output + " гривень");
            }
            else if (InputNumber == "5")
            {
                Output = Input * eur;
                Console.WriteLine(Output + " гривень");
            }
            else if (InputNumber == "6")
            {
                Output = Input * rub;
                Console.WriteLine(Output + " гривень");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            double usd = 26.73;
            double eur = 31.32;
            double rub = 0.37;
            Converter process = new Converter(usd, eur, rub);
            Console.ReadLine();
        }
        
    }
    
}
