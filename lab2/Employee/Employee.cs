using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        private readonly string name;
        private readonly string secondname;
        public Employee(string name, string secondname)
        {
            this.name = name;
            this.secondname = secondname;
        }
        public void salary()
        {
            int position, experience;
            double salary, tax;
            Console.WriteLine("Вы имеете 3 должности и опыт роботы");
            Console.WriteLine("Укажите должность:");
            Console.WriteLine("1) младший программист");
            Console.WriteLine("2) младший графический дизайнер");
            Console.WriteLine("3) старший програмист");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите опыт роботы");
            experience = Convert.ToInt32(Console.ReadLine());
            if (position == 1 && experience <= 3)
            {
                Console.WriteLine("Вы младший программист");
                salary = ((50002.05 + 78950.61) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Ваш оклад: {salary}");
                Console.WriteLine($"Ваш налоговый сбор: {tax}");
            }
            if (position == 2 && experience <= 3)
            {
                Console.WriteLine("Вы младший графический дизайнер");
                salary = ((53000 + 23000) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Ваш оклад: {salary}");
                Console.WriteLine($"Ваш налоговый сбор: {tax}");
            }
            if (position == 3 && experience >= 10)
            {
                Console.WriteLine("Вы старший програмист");
                salary = ((52633.74 + 82503.39) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Ваш оклад: {salary}");
                Console.WriteLine($"Ваш налоговый сбор: {tax}");
            }
            Console.WriteLine($"Вы {name} {secondname} и ваша должность {position}.");
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee("VJ", "Link");
            employee.salary();
        }
    }
}
