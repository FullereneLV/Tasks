using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
//    Завдання 2

//Створiть та опишiть клас «Місто».

//Виконайте перевантаження

//+ (для збільшення кількості жителів на вказану кількість),

//– (для зменшення кількості жителів на вказану кількість),

//== та != (перевірка на рівність/не рiвнiсть двох міст за кількістю жителів),

//< і > (перевірка на меншу чи більшу кількість мешканців),

//Використовуйте механізм властивостей полів класу.
    internal class City
    {
        public int People {  get; set; }    

        public static City operator +(City c1, int c2)
        {
            return new City { People = c1.People + c2 };
        }

        public static City operator -(City c1, int c2)
        {
            //var result = 0;
            //if (c1.People > c2.People)
            //{
            //    result = c1.People - c2.People;
            //}
            //else
            //{
            //    result = c2.People - c1.People;
            //}
            return new City { People = c1.People - c2 };
        }

        public static bool operator >(City c1, City c2)
        {
            return c1.People > c2.People;
        }

        public static bool operator <(City c1, City c2)
        {
            return c1.People < c2.People;
        }

        public static bool operator ==(City c1, City c2)
        {
            return c1.People == c2.People;
        }

        public static bool operator !=(City c1, City c2)
        {
            return !(c1 == c2);
        }

    }
}
