using System;

namespace denem
{
    class Program
{
    
// See https://aka.ms/new-console-template for more information
 static void Main(string[] args)
{
        Console.WriteLine("Adınız Giriniz: ");
        string name =Console.ReadLine();
        Console.WriteLine("Soyadınız Giriniz: ");
        string surname =Console.ReadLine();

        Console.WriteLine($"merhaba {name} {surname}");
}
}
}

