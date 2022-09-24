using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        private double HryvniaCal { get; set; }
        private readonly double usd;
        private readonly double eur;
        public Converter(double Usd, double Eur)
        {
            this.usd = Usd;
            this.eur = Eur;
        }
        public double convert()
        {
            int choice;
            int number;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Пожалуйста, укажите суму");
                    number = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = number * usd;
                    Console.WriteLine($"Вы получите {HryvniaCal} гривен");
                    break;
                case 2:
                    Console.WriteLine("Пожалуйста, укажите суму");
                    number = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = number * eur;
                    Console.WriteLine($"Вы получите {HryvniaCal} гривен");
                    break;
                case 3:
                    Console.WriteLine("Пожалуйста, укажите суму");
                    number = Convert.ToInt32(Console.ReadLine());
                    double UsD = number / 26.32;
                    Console.WriteLine($"Вы получите {UsD} долларов");
                    break;
                case 4:
                    Console.WriteLine("Пожалуйста, укажите суму");
                    number = Convert.ToInt32(Console.ReadLine());
                    double EuR = number / 30.36;
                    Console.WriteLine($"Вы получите {EuR} евро");
                    break;
                default:
                    Console.WriteLine("Попробуйте снова");
                    break;
            }
            return HryvniaCal;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Какой обмен вы хотите выбрать?");
            Console.WriteLine("1) конвертировать доллары в гривны");
            Console.WriteLine("2) конвертировать евро в гривны");
            Console.WriteLine("3) конвертировать гривны в доллары");
            Console.WriteLine("4) конвертировать гривны в евро");
            Converter converter = new Converter(26.32, 30.36);
            converter.convert();
        }
    }
}
