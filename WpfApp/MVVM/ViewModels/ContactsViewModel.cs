using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp.Helpers;
using WpfApp.Models;
using WpfApp.Services;

namespace WpfApp.MVVM.ViewModels;

internal partial class ContactsViewModel : _ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Contact> contacts = ContactService.Contacts();

    [ObservableProperty]
    private Contact selectedContact = null!;


    private readonly NavigationStore _navigationStore;
    private readonly ContactService _contactService;


    public ICommand NavigateToAddCommand { get; }

    public ContactsViewModel(NavigationStore navigationStore, ContactService contactService)
    {
        _navigationStore = navigationStore;
        _contactService = contactService;
        NavigateToAddCommand = new NavigateCommand<AddContactViewModel>(navigationStore, () => new AddContactViewModel(_navigationStore, _contactService));
    }
}
