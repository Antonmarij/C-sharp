using System.Collections.ObjectModel;
using ToDoListApp.Models;

namespace ToDoListApp;

public partial class MainPage : ContentPage
{
    ObservableCollection<Todo> Todos = new ObservableCollection<Todo>(); 


    public MainPage()
    {
        InitializeComponent();
        TodoList.ItemsSource = Todos;
    }
    private void AddButton_Clicked(object sender, EventArgs e)
    {
        Todos.Add(new Todo { Activity = ToDoActivity.Text });
        ToDoActivity.Text = string.Empty;
    }
    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var todo = button.BindingContext as Todo;

        Todos.Remove(todo);
    }
}