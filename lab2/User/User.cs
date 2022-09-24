using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        public string Login { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public int Age { get; set; }
        public string Date_of_completion { get; set; }
        public void worksheet()
        {
            Console.WriteLine("Создание новой анкеты");
            Console.WriteLine("Придумайте логин");
            Login = Console.ReadLine();
            Console.WriteLine("Укажите ваше имя");
            Firstname = Console.ReadLine();
            Console.WriteLine("Укажите вашу фамилию");
            Secondname = Console.ReadLine();
            Console.WriteLine("Укажите возраст");
            Age = Convert.ToInt32(Console.ReadLine());
            Date_of_completion = DateTime.Now.ToString();
            Console.WriteLine($"");
            Console.WriteLine($"ВАША АНКЕТА");
            Console.WriteLine($"Логин: {Login}");
            Console.WriteLine($"Имя: {Firstname} {Secondname}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Дата создания анкеты: {Date_of_completion}");
        }
        static void Main(string[] args)
        {
            User u = new User();
            u.worksheet();
        }
    }
}