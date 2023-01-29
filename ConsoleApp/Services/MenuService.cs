using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using Newtonsoft.Json;

namespace ConsoleApp.Services;

internal class MenuService
{
    private List<IContact> contacts = new();
    private readonly FileService file = new();

    public string FilePath { get; set; } = null!;

    private void PopulateContactsList()
    {
        try
        {
            var items = JsonConvert.DeserializeObject<List<IContact>>(file.Read(FilePath));
            if (items != null)
                contacts = items;
        }
        catch { }
    }

    public void WelcomeMenu()
    {
        //PopulateContactsList();
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
        Console.WriteLine("Skapa en kontakt");

        IContact contact = new Contact();

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
        foreach (Contact contact in contacts)
        {
            Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.Email}");
        }
    }

    private void OptionThree()
    {

    }

    private void OptionFour()
    {

    }
}
