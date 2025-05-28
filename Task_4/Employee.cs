using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    //    Завдання 1 

    //Створiть та опишiть клас «Співробітник».

    //Додайте до вже створеного класу інформацію про заробітну плату працівника.

    //Виконайте перевантаження

    //+ (для збільшення зарплати на вказану кількість),

    //– (для зменшення зарплати на вказану кількість),

    //== та != (перевірка на рівність/не рiвнiсть зарплат працівників),

    //< і > (перевірка на меншу чи більшу кількість зарплат працівників),

    //Використовуйте механізм властивостей полів класу.
    class Employee
    {
        public int Salary { get; set; }

        public static Employee operator +(Employee counter1, Employee counter2)
        {
            return new Employee { Salary = counter1.Salary + counter2.Salary };
        }

        public static Employee operator -(Employee counter1, Employee counter2)
        {
            var result = 0;
            if (counter1.Salary > counter2.Salary)
            {
                result = counter1.Salary - counter2.Salary;
            }
            else
            {
                result = counter2.Salary - counter1.Salary;
            }
            return new Employee { Salary = result };
        }

        public static bool operator >(Employee counter1, Employee counter2)
        {
            return counter1.Salary > counter2.Salary;
        }

        public static bool operator <(Employee counter1, Employee counter2)
        {
            return counter1.Salary < counter2.Salary;
        }

        public static bool operator ==(Employee counter1, Employee counter2)
        {
            return counter1.Salary == counter2.Salary;
        }

        public static bool operator !=(Employee counter1, Employee counter2)
        {
            return !(counter1 == counter2);
        }

    }
}
