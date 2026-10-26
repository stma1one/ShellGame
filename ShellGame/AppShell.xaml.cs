using ShellGame.Views;
namespace ShellGame;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        RoutingPages();
    }

    private void RoutingPages()
    {
        Routing.RegisterRoute("Page3", typeof(NewPage3));
    }
}
