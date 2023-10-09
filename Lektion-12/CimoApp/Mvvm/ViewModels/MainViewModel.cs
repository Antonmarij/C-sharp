using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.Views;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace CimoApp.Mvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        UpdateContacts();
        ContactService.ContactsUpdated += UpdateContacts;

    }

    void UpdateContacts()
    {
     foreach (var contact in ContactService.GetContacts())
                Contacts.Add(contact);       
    }



    [ObservableProperty]
    ObservableCollection<ContactModel> contacts;

    [RelayCommand]
    async Task GoToAdd() => await Shell.Current.GoToAsync(nameof(AddPage));
    

}
