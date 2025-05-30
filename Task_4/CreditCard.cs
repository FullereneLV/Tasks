using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
//    Завдання 3

//Створiть та опишiть клас «Кредитна картка».

//Додайте до вже створеного класу інформацію про суму грошей на картці.

//Виконайте перевантаження

//+ (для збільшення суми грошей на вказану кількість),

//– (для зменшення суми грошей на вказану кількість),

//== та != (перевірка на рівність/не рiвнiсть CVC коду),

//< і > (перевірка на меншу чи більшу кількість суми грошей),

//Використовуйте механізм властивостей полів класу.
    internal class CreditCard
    {
        public int cvcCode {  get; set; }   
        public double Money { get; set; }

        public static CreditCard operator +(CreditCard c1, double addMoney)
        {
            return new CreditCard { Money = c1.Money + addMoney };
        }

        public static CreditCard operator -(CreditCard c1, double takeMoney)
        {
            double result = 0;
            if (c1.Money > takeMoney)
            {
                result = c1.Money - takeMoney;
            }
            else
            {
                Console.WriteLine("You don't have enough money");
                result = c1.Money;
            }
            return new CreditCard { Money = result };
        }

        public static bool operator >(CreditCard c1, CreditCard c2)
        {
            return c1.Money > c2.Money;
        }

        public static bool operator <(CreditCard c1, CreditCard c2)
        {
            return c1.Money < c2.Money;
        }

        public static bool operator ==(CreditCard cvv1, int cvv)
        {
            return cvv1 == cvv;
        }

        public static bool operator !=(CreditCard cvc1, int cvv)
        {
            return !(cvc1 == cvv);
        }
    }
}
