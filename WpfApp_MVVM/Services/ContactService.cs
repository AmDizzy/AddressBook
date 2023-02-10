using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using WpfApp_MVVM.Models;

namespace WpfApp_MVVM.Services;

public static class ContactService
{
    private static ObservableCollection<Contact> contacts;
    private static readonly FileService file = new FileService(@$"{AppDomain.CurrentDomain.BaseDirectory}\content.json");

    static ContactService()
    {
        try
        {
            contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(file.Read())!;
            contacts.Clear();
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
