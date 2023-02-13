using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.Helpers;
using WpfApp.Services;

namespace WpfApp.MVVM.ViewModels;

internal class NavigationBarViewModel : _ObservableObject
{
    private readonly NavigationStore _navigationStore;
    private readonly ContactService _contactService;

    public ICommand GoToAddContactCommand { get; }
    public ICommand GoToContactsCommand { get; }

    public NavigationBarViewModel(NavigationStore navigationStore, ContactService contactService)
    {
        _navigationStore = navigationStore;
        _contactService = contactService;
        GoToAddContactCommand = GoToAddContact();
        GoToContactsCommand = GoToContacts();
    }

    private ICommand GoToAddContact()
    {
        return new NavigateCommand<AddContactViewModel>(_navigationStore, () => new AddContactViewModel(_navigationStore, _contactService));
    }

    private ICommand GoToContacts()
    {
        return new NavigateCommand<ContactsViewModel>(_navigationStore, () => new ContactsViewModel(_navigationStore, _contactService));
    }

    //private readonly NavigationStore _navigationStore;
    //private readonly ContactService _contactService;
    //public ICommand GoToContactsCommand { get; }
    //public ICommand GoToAddContactCommand { get; }

    ////public NavigationBarViewModel(NavigationStore navigationStore, ContactService contactService)
    ////{
    ////    _navigationStore = navigationStore;
    ////    _contactService = contactService;
    ////    //GoToContactsCommand = new NavigateCommand<ContactsViewModel>(contactService, () => new ContactsViewModel(_navigationStore, _contactService));
    ////    //GoToAddContactCommand = new NavigateCommand<AddContactViewModel>(contactService, () => new AddContactViewModel(_navigationStore, _contactService));
    ////    //GoToAddContactCommand = new NavigateCommand<AddContactViewModel>(_navigationStore);

    ////}
}
