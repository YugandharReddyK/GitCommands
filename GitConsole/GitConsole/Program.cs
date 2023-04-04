namespace GitConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    internal class Student
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}