

namespace Task_6
{
    public class StagePlay : IDisposable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearOfPublication { get; set; }

        public StagePlay(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            YearOfPublication = year;
        }

        ~StagePlay()
        {
            Console.WriteLine($"{Name}, {Author} and {Genre} have been removed");
        }

        public void StartPlay()
        {
            Console.WriteLine($"Play is: \"{Name}\"");
        }

        public void Dispose()
        {
            Console.WriteLine($"{Name} is disposed!");
        }
    }
}
