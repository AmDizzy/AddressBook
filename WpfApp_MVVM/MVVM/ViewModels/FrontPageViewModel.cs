﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WpfApp_MVVM.Models;
using WpfApp_MVVM.Services;

namespace WpfApp_MVVM.MVVM.ViewModels;

public partial class FrontPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string pageTitle = "Kontakter:";

    [ObservableProperty]
    private ObservableCollection<Contact> contacts = ContactService.Contacts();

    [ObservableProperty]
    private Contact selectedContact = null!;
}
