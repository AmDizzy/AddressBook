using CommunityToolkit.Mvvm.Input;
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
using WpfApp_MVVM.MVVM.ViewModels;
using WpfApp_MVVM.Services;

namespace WpfApp_MVVM.MVVM.Views;

public partial class AddContactView : UserControl
{
    private ObservableCollection<Contact> contacts = ContactService.Contacts();

    public AddContactView()
    {
        InitializeComponent();
    }


    private void Btn_Add_Click(object sender, RoutedEventArgs e)
    {
        ContactService.Add(new Contact
        {
            FirstName = tb_FirstName.Text,
            LastName = tb_LastName.Text,
            Email = tb_Email.Text,
            PhoneNumber = tb_PhoneNumber.Text,
            StreetAdress = tb_StreetAdress.Text,
            PostalCode = tb_PostalCode.Text,
            City = tb_City.Text
        });

        ClearForm();
    }

    private void ClearForm()
    {
        tb_FirstName.Text = "";
        tb_LastName.Text = "";
        tb_Email.Text = "";
        tb_PhoneNumber.Text = "";
        tb_StreetAdress.Text = "";
        tb_PostalCode.Text = "";
        tb_City.Text = "";
    }

    private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
    {
        ClearForm();
    }
}
