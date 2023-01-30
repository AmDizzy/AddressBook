using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ConsoleApp.Services;

internal class MenuService
{
    private ObservableCollection<Contact> contacts = new();
    private readonly FileService file = new();

    public string FilePath { get; set; } = null!;

    private void PopulateContactsList()
    {
        try
        {
            var items = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(file.Read(FilePath));
            if (items != null)
                contacts = items;
        }
        catch { }
    }

    public void WelcomeMenu()
    {
        PopulateContactsList();
        Console.Clear();
        Console.WriteLine("Välkommen till Adressboken");
        Console.WriteLine("1. Skapa en kontakt");
        Console.WriteLine("2. Visa alla kontakter");
        Console.WriteLine("3. Visa en specifik kontakt");
        Console.WriteLine("4. Ta bort en specifik kontakt");
        Console.Write("Välj ett av alternativen ovan: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1": OptionOne(); break;
            case "2": OptionTwo(); break;
            case "3": OptionThree(); break;
            case "4": OptionFour(); break;
        }
        file.Save(FilePath, JsonConvert.SerializeObject(contacts));
    }

    private void OptionOne()
    {
        Console.Clear();
        Console.WriteLine("Skapa en kontakt:");
        Console.WriteLine("\n");

        Contact contact = new();

        Console.Write("Ange Förnamn: ");
        contact.FirstName = Console.ReadLine() ?? "";

        Console.Write("Ange Efternamn: ");
        contact.LastName = Console.ReadLine() ?? "";

        Console.Write("Ange E-postadress: ");
        contact.Email = Console.ReadLine() ?? "";

        Console.Write("Ange Telefonnummer: ");
        contact.PhoneNumber = Console.ReadLine() ?? "";

        Console.Write("Ange Adress: ");
        contact.Address = Console.ReadLine() ?? "";


        contacts.Add(contact);
    }

    private void OptionTwo()
    {
        Console.Clear();
        Console.WriteLine("Alla kontakter:");
        foreach (Contact contact in contacts)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.Email}");
        }
        Console.WriteLine("\n");
        Console.Write("Tryck på valfri tangent för att gå tillbaka...");
        Console.ReadKey();
    }

    private void OptionThree()
    {
        Console.Clear();
        Console.WriteLine("Visa en specifik kontakt:");
        Console.WriteLine("\n");
        var i = 0;
        foreach (Contact contact in contacts)
        {

            Console.WriteLine($"{i}. {contact.FirstName} {contact.LastName} {contact.Email}");
            i++;
        }
        Console.WriteLine("\n");
        Console.Write("Välj kontakten du vill visa t.ex. 1: ");
        try
        {
            int option = Convert.ToInt32(Console.ReadLine());
            var contact = contacts[option];
            Console.Clear();
            Console.WriteLine($"Förnamn: {contact.FirstName}");
            Console.WriteLine($"Efternamn: {contact.LastName}");
            Console.WriteLine($"E-postadress: {contact.Email}");
            Console.WriteLine($"Telefonnummer: {contact.PhoneNumber}");
            Console.WriteLine($"Adress: {contact.Address}");
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Kunde inte visa kontakten.");
        }
        Console.WriteLine("\n");
        Console.Write("Tryck på valfri tangent för att gå tillbaka...");
        Console.ReadKey();
    }

    private void OptionFour()
    {
        Console.Clear();
        Console.WriteLine("Radera en kontakt:");
        Console.WriteLine("\n");
        var i = 0;
        foreach (Contact contact in contacts)
        {
            
            Console.WriteLine($"{i}. {contact.FirstName} {contact.LastName} {contact.Email}");
            i++;
        }
        Console.WriteLine("\n");
        Console.Write("Välj kontakten du vill ta bort t.ex. 1: ");
        try
        {
            int option = Convert.ToInt32(Console.ReadLine());
            var contact = contacts[option];
            Console.Clear();
            Console.WriteLine($"Kontakten {contact.FirstName} {contact.LastName} {contact.Email} {contact.PhoneNumber} {contact.Address} är vald.");
            Console.Write("Är du säker på att du vill radera kontakten? (y/n): ");
            var confirm = Console.ReadLine()?.ToLower();
            if (confirm == "y")
            {
                contacts.RemoveAt(option);
                Console.Clear();
                Console.WriteLine("Kontakten raderades.");
            }
            else if (confirm == "n")
                Console.Write("");
            else Console.WriteLine("Vänligen försök igen.");
            
        }
        catch 
        {
            Console.Clear();
            Console.WriteLine("Kunde inte radera kontakten.");
        }

        Console.WriteLine("\n");
        Console.Write("Tryck på valfri tangent för att gå tillbaka...");
        Console.ReadKey();
    }
}
