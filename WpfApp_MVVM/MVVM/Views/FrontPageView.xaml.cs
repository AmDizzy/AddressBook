using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp_MVVM.Interfaces;
using WpfApp_MVVM.Models;
using WpfApp_MVVM.Services;

namespace WpfApp_MVVM.MVVM.Views;

public partial class FrontPageView : UserControl
{
    private ObservableCollection<Contact> contacts = new();
    private readonly FileService file = new();
    public FrontPageView()
    {
        InitializeComponent();

        file.FilePath = @$"{AppDomain.CurrentDomain.BaseDirectory}\content.json";

        PopulateContactsList();
    }

    private void PopulateContactsList()
    {
        try
        {
            var items = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(file.Read());
            if (items != null)
                contacts = items;
        }
        catch { }

        lv_Contacts.ItemsSource = contacts;
    }
}
