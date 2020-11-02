using System;

namespace АлтГУ_Тестовое_задание_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Курс \"Разработка интернет - приложений на платформе C# ASP.Net MVC\"");
            Console.WriteLine("Входное задание - “Класс «Сотрудник»”");
            Console.WriteLine("Студент - Казаченко Валерий");
            Console.WriteLine("02 ноября 2020\n\n");

            Employee employee1 = new Employee("Семён", "Семёныч", "Горбунков", EmpType.директор, Department.Администраця, 100000m);
            Employee employee2 = new Employee("Пётр", "Иванович", "Перестукин", EmpType.грузчик, Department.Склад, 31856m);

            employee1.DisplayEmployee();
            employee2.DisplayEmployee();

            Console.Read();
        }
    }
}
