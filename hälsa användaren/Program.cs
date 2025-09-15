namespace hälsa_användaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            SayHello(name);

        }
        static void SayHello(string name)
        {
        Console.WriteLine($"Hej {name}, välkommen till programmet!" );
            }
}

    }

