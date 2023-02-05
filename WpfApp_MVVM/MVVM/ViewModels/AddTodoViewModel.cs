using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_MVVM.MVVM.ViewModels;

public partial class AddTodoViewModel : ObservableObject
{
    [ObservableProperty]
    private string pageTitle = "Add Todos";

    [ObservableProperty]
    private string todo = string.Empty;

    [RelayCommand]
    private void AddTodo()
    {

    }
}
