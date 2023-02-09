using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Controls;
using WpfApp.Interfaces;
using WpfApp.Models;
using WpfApp.Services;

namespace WpfApp;

public partial class MainWindow : Window
{
    private ObservableCollection<Contact> contacts = new();
    //private readonly FileService file = new();
    public MainWindow()
    {
        InitializeComponent();

        //file.FilePath = @$"{AppDomain.CurrentDomain.BaseDirectory}\contentWPF.json";

        //PopulateContactsList();
    }

    //private void PopulateContactsList()
    //{
    //    try
    //    {
    //        var items = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(file.Read());
    //        if (items != null)
    //            contacts = items;
    //    }
    //    catch { }

    //    lv_Contacts.ItemsSource = contacts;
    //}

    //private void Btn_Add_Click(object sender, RoutedEventArgs e)
    //{
    //    contacts.Add(new Contact
    //    {
    //        FirstName = tb_FirstName.Text,
    //        LastName = tb_LastName.Text,
    //        Email = tb_Email.Text,
    //        PhoneNumber = tb_PhoneNumber.Text,
    //        StreetAdress = tb_StreetAdress.Text,
    //        PostalCode = tb_PostalCode.Text,
    //        City = tb_City.Text
    //    });

    //    file.Save(JsonConvert.SerializeObject(contacts));
    //    ClearForm();
    //}

    //private void ClearForm()
    //{
    //    tb_FirstName.Text = "";
    //    tb_LastName.Text = "";
    //    tb_Email.Text = "";
    //    tb_PhoneNumber.Text = "";
    //    tb_StreetAdress.Text = "";
    //    tb_PostalCode.Text = "";
    //    tb_City.Text = "";
    //}

    private void lbox_NavMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selected = lbox_NavMenu.SelectedItems as NavButton;
        frame_PageFrame.Navigate(selected?.NavLink);
    }
}
