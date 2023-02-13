using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.MVVM.ViewModels;
using WpfApp.Services;

namespace WpfApp.Helpers;

internal class NavigateCommand<T> : BaseCommand where T : _ObservableObject
{
    private readonly NavigationStore _navigationStore;
    private readonly Func<T> _createViewModel;

    public NavigateCommand(NavigationStore navigationStore, Func<T> createViewModel)
    {
        _navigationStore = navigationStore;
        _createViewModel = createViewModel;
    }

    public override void Execute(object? parameter)
    {
        _navigationStore.CurrentViewModel = _createViewModel();
    }
}
