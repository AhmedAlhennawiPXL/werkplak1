namespace Werkplek1;
using System;

class Program
{
    static void Main()

    {
        const string user = "Admin";
        const string password = "P@sswoord123";
        int tries = 0;

        Console.Write("Gebruikersnaam: ");
        string inputUser = Console.ReadLine();
        Console.Write("Wachtwoord: ");
        string inputPassword = Console.ReadLine();

        if (inputUser == user && inputPassword == password)
            tries++;
        Console.WriteLine($"Foutieve login.\n{3 - tries} pogingen over.");
        Console.WriteLine("Te veel pogingen. Toegang geweigerd.");






    }
}

