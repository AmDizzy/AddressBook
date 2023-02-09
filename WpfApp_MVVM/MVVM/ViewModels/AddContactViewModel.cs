using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp_MVVM.MVVM.ViewModels;

public partial class AddContactViewModel : ObservableObject
{
    [ObservableProperty]
    private string pageTitle = "Lägg till en kontakt:";

    [RelayCommand]
    private void AddContactPage()
    {

    }
}
