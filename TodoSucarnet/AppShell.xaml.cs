using TodoSucarnet.Views;
namespace TodoSucarnet;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
    }
}
