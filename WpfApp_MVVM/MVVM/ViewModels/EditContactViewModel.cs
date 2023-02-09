using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp_MVVM.MVVM.ViewModels;

public partial class EditContactViewModel : ObservableObject
{
    [ObservableProperty]
    private string pageTitle = "Ändra en kontakt:";

    [RelayCommand]
    private void EditContactPage()
    {

    }
}
