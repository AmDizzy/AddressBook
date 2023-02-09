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

public partial class FrontPageView : UserControl
{
    private ObservableCollection<Contact> contacts = ContactService.Contacts();
    public FrontPageView()
    {
        InitializeComponent();
    }

    private void btn_Edit_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        var contact = (Contact)button.DataContext;
    }

    private void btn_Remove_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        var contact = (Contact)button.DataContext;

        var result = MessageBox.Show("Är du säker på att du vill radera kontakten", "Radera Kontakten", MessageBoxButton.YesNo);

        if (result == MessageBoxResult.Yes)
        {
            ContactService.Remove(contact);
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var Button = (Button)sender;
        var contact = (Contact)Button.DataContext;
    }
}
