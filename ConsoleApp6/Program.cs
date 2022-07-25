// See https://aka.ms/new-console-template for more information
using ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int a = rnd.Next(100000,200000)/ 100;
        int b = 22 * a;
        Console.WriteLine(rnd);
        Console.WriteLine(b);
    }

}


