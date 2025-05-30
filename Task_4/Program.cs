// See https://aka.ms/new-console-template for more information
using Task_4;


static void StartTask4()
{
    Console.WriteLine("Start task 4.1");
    Employee salary1 = new Employee { Salary = 200 };
    Employee salary2 = new Employee { Salary = 300 };
    Console.WriteLine("Emploee 1 has salary = " + salary1.Salary);
    Console.WriteLine("Emploee 2 has salary = " + salary2.Salary);
    Console.WriteLine("Operator overloading == ");
    bool result = salary1 == salary2;
    Console.WriteLine(result);
    Console.WriteLine("Operator overloading salary1 > salary2:");
    bool result1 = salary1 > salary2;
    Console.WriteLine(result1);
    Console.WriteLine("Operator overloading salary1 < salary2:");
    bool result2 = salary1 < salary2;
    Console.WriteLine(result2);
    Console.WriteLine("Operator overloading != ");
    bool result3 = salary1 != salary2;
    Console.WriteLine(result3);
    Console.WriteLine("Operator overloading - ");
    Employee result4 = salary1 - salary2;
    Console.WriteLine(result4.Salary);
    Console.WriteLine("Operator overloading + ");
    Employee result5 = salary1 + salary2;
    Console.WriteLine(result5.Salary);
}

static void Task2()
{
    Console.WriteLine("Start task 4.2");
    City city1 = new City { People = 1000  };
    City city2 = new City { People = 50  };
    Console.WriteLine("City 1 = " + city1.People); 
    Console.WriteLine("City 2 = " + city2.People); 
    Console.WriteLine("Operator overloading == ");
    bool result = city1 == city2;
    Console.WriteLine(result);
    Console.WriteLine("Operator overloading city1 > city2:");
    bool result1 = city1 > city2;
    Console.WriteLine(result1);
    Console.WriteLine("Operator overloading city1 < city2:");
    bool result2 = city1 < city2;
    Console.WriteLine(result2);
    Console.WriteLine("Operator overloading != ");
    bool result3 = city1 != city2;
    Console.WriteLine(result3);
    Console.WriteLine("Operator overloading - 10");
    City result4 = city1 - 10;
    Console.WriteLine(city1.People = result4.People);
    Console.WriteLine("Operator overloading + 1000");
    City result5 = city1 + 1000;
    Console.WriteLine(result5.People);
}

static void Task3()
{
    Console.WriteLine("Start task 4.3");
    CreditCard card = new CreditCard { Money = 5000, cvcCode = 123 };
    Console.WriteLine("Credit card has money " + card.Money);
    Console.WriteLine("Operator overloading == 123");
    bool result = card.cvcCode == 123;
    Console.WriteLine(result);
    Console.WriteLine("Operator overloading money > 4000:");
    bool result1 = card.Money > 4000;
    Console.WriteLine(result1);
    Console.WriteLine("Operator overloading money < 5001:");
    bool result2 = card.Money < 5001;
    Console.WriteLine(result2);
    Console.WriteLine("Operator overloading != 222");
    bool result3 = card.cvcCode!= 222;
    Console.WriteLine(result3);
    Console.WriteLine("Operator overloading - 10.00");
    double result4 = card.Money - 10.00;
    Console.WriteLine(card.Money = result4);
    Console.WriteLine("Operator overloading + 1000");
    double result5 = card.Money + 1000;
    Console.WriteLine(result5);
}

StartTask4();
Task2();
Task3();
