using System;

namespace MyPlants
{
    internal class Program
    { 
        static void Main(string[] args)
    {
        Console.Title = "Растения";

        Console.WriteLine("---Мои растения---");
        try
        {
            View.MyConsole myconsole = new View.MyConsole("Plants.bin");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Программа закончила свою работу ");
        Console.ReadLine();
    }
}

}