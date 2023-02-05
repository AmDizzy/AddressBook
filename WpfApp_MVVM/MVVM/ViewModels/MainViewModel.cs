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
    private ObservableObject currentViewModel;

    [RelayCommand]
    private void GoToFrontPage() => CurrentViewModel = new FrontPageViewModel();

    [RelayCommand]
    private void GoToTodos() => CurrentViewModel = new TodosViewModel();

    public MainViewModel()
    {
        CurrentViewModel = new FrontPageViewModel();
    }
}
