using System;
namespace Uppgift2
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("var är du ifrån?");
            string plats = Console.ReadLine();
            Console.WriteLine("vart vill du resa i framtiden");
            string annanplats = Console.ReadLine();

            Console.WriteLine("hej " + plats + "-bo. jag hoppas att du kan resa till " + annanplats);
        }
    }
}
