
namespace Task_6
{
    internal class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public Shop(string name,string address,string type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        ~Shop()
        {
            Console.WriteLine("Object Destroyed.");
        }

        public void Dispose()
        {
            Console.WriteLine($"{Name} - {Type} is disposed!");
        }
    }
}
