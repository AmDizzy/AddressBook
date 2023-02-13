using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using WpfApp.Models;

namespace WpfApp.Services;

internal class ContactService
{
    private static ObservableCollection<Contact> contacts;
    private static readonly FileService file = new(@$"{AppDomain.CurrentDomain.BaseDirectory}\content.json");

    static ContactService()
    {
        try
        {
            contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(file.Read())!;
        }
        catch { contacts = new ObservableCollection<Contact>(); }
    }

    public static void Add(Contact model)
    {
        contacts.Add(model);
        file.Save(JsonConvert.SerializeObject(contacts));
    }

    public static void Remove(Contact model)
    {
        contacts.Remove(model);
        file.Save(JsonConvert.SerializeObject(contacts));

    }

    public static ObservableCollection<Contact> Contacts()
    {
        return contacts;
    }
}
