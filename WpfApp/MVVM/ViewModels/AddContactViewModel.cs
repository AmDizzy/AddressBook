using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.Helpers;
using WpfApp.Services;

namespace WpfApp.MVVM.ViewModels;

internal class AddContactViewModel : _ObservableObject
{
    private readonly NavigationStore _navigationStore;
    private readonly ContactService _contactService;

    public ICommand AddCommand { get; }
    public ICommand CancelCommand { get; }

    public AddContactViewModel(NavigationStore navigationStore, ContactService contactService)
    {
        _navigationStore = navigationStore;
        _contactService = contactService;
        AddCommand = AddContact();
        CancelCommand = Cancel();
    }


    private ICommand AddContact()
    {
        return new NavigateCommand<AddContactViewModel>(_navigationStore, () => new AddContactViewModel(_navigationStore, _contactService));
    }

    private ICommand Cancel()
    {
        return new NavigateCommand<ContactsViewModel>(_navigationStore, () => new ContactsViewModel(_navigationStore, _contactService));
    }
}
