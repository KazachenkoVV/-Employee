using System;
using System.Text;

namespace АлтГУ_Тестовое_задание_Employee
{
    // Класс сотрудинки
    class Employee
    {
        internal string FirstName { get; private set; }       // Имя
        internal string MiddleName { get; private set; }      // Отчество
        internal string SecondName { get; private set; }      // Фамилия
        internal EmpType Empl { get; private set; }           // Должность
        internal Department Department { get; private set; }  // Отдел
        internal decimal Salary { get; private set; }         // Оклад

        internal Employee(string firstName,
                          string middleName,
                          string secondName,
                          EmpType empl,
                          Department department,
                          decimal salary)
        {
            FirstName = firstName;
            MiddleName = middleName;
            SecondName = secondName;
            Empl = empl;
            Department = department;
            Salary = salary;
        }

        // Вывод карточки сотрудника
        internal void DisplayEmployee()
        {
            Console.WriteLine("Карточка сотрудника\n");
            Console.WriteLine($"Фамилия   - {SecondName}");
            Console.WriteLine($"Имя       - {FirstName}");
            Console.WriteLine($"Отчество  - {MiddleName}\n");
            Console.WriteLine($"Должность - {Empl}");
            Console.WriteLine($"Отдел     - {Department}");
            Console.WriteLine($"Оклад     - {Salary:C2}");
            Console.WriteLine("------------------------\n");
        }
    }
}
