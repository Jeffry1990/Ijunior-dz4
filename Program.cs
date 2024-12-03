namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Артур";
            string surname = "Володин";
            string temporaryName;

            Console.WriteLine("До замены:");
            Console.WriteLine($"Имя - {name}");
            Console.WriteLine($"Фамилия - {surname}");

            temporaryName = name;
            name = surname;
            surname = temporaryName;

            Console.WriteLine();
            Console.WriteLine("После замены:");
            Console.WriteLine($"Имя - {name}");
            Console.WriteLine($"Фамилия - {surname}");
        }
    }
}