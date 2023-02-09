using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_MVVM.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableObject currentViewModel = new FrontPageViewModel();

    [RelayCommand]
    private void GoToFrontPage() => CurrentViewModel = new FrontPageViewModel();

    [RelayCommand]
    private void GoToAddContactPage() => CurrentViewModel = new AddContactViewModel();

    [RelayCommand]
    private void GoToEditContactPage() => CurrentViewModel = new EditContactViewModel();

}
