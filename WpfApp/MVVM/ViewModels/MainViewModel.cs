using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Services;

namespace WpfApp.MVVM.ViewModels;

internal class MainViewModel : _ObservableObject
{
    private readonly NavigationStore _navigationStore;
    public MainViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
    }

    public _ObservableObject CurrentViewModel => _navigationStore.CurrentViewModel;

    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}
