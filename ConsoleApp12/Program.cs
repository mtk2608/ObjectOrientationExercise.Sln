// See https://aka.ms/new-console-template for more information
//using ConsoleApp12;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book HarryPotter = new Book(true, 251, "HardCover", "Fiction", "02/07/1998");

            Console.WriteLine("Harry Potter:Chamber of Secrets - No of Pages: " + HarryPotter.NoOfPages);




        }
    }
}
