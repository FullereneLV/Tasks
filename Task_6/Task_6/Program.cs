// See https://aka.ms/new-console-template for more information


using Task_6;

long tMemory = GC.GetTotalMemory(false);
Console.WriteLine(tMemory);

int num = 1000;
tMemory = GC.GetTotalMemory(false);
Console.WriteLine(tMemory);

GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine(GC.GetTotalMemory(false));

var shop1 = new Shop("Mercury", "mercury@gmail.com", "music");
try
{
    Console.WriteLine(shop1.Name);
    Console.WriteLine();
}
finally
{
    shop1.Dispose();
}

var shop2 = new Shop("ATB", "atb@gmail.com", "supermarket");
using (shop2)
{
    Console.WriteLine(shop2.Name);
    Console.WriteLine();
}

var shop3 = new Shop("Silpo", "silpo@ukr.ua", "supermarket");
Console.WriteLine(shop3.Name);
Console.WriteLine(shop3.Address);
Console.WriteLine(shop3.Type);
Console.WriteLine();

var play2 = new StagePlay("Dead", "USA", "drama", 2013);
using (play2)
{
    Console.WriteLine(play2.Name);
    Console.WriteLine(play2.Genre);
    Console.WriteLine();
   
}

TestShop1();

TestPlay1();
void TestPlay1()
{
    Console.WriteLine("Start test play 1:");
    StagePlay play1 = new StagePlay("A play with words", "Peter Bloedel", "Comedy", 2023);
    play1.StartPlay();
    Console.WriteLine();
}

void TestShop1()
{
    Console.WriteLine("Start test shop1");
    Shop shop = new Shop("MAC", "mac@gmail.com", "technoligy");
    Console.WriteLine(shop.Name);
    Console.WriteLine(shop.Address);
    Console.WriteLine(shop.Type);
    Console.WriteLine();
}


