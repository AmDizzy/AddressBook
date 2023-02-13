using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.MVVM.ViewModels;

namespace WpfApp.Services;

internal class NavigationStore
{
    public event Action? CurrentViewModelChanged;

    private _ObservableObject? _currentViewModel;
    public _ObservableObject CurrentViewModel
    {
        get => _currentViewModel!;
        set
        {
            _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }

    private void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}
