using System.Windows.Input;
using ShellGame.Models;
namespace ShellGame.Views;

public partial class NewPage2 : ContentPage
{

    private Student student;
    string vote="באים לקפוץ לומר שלום בבחירות ";
	public ICommand NavigateToPageCommand { get; set; }
	public NewPage2()
	{
		InitializeComponent();
		NavigateToPageCommand = new Command(async () => await NavigatePage3());
        BindingContext = this;
        student= new Student
        {
            Name = "Jonathan",
            Age = 17,
            Educator = "טליה פריד"
        };

    }

    private async Task NavigatePage3()
    {
       // await Shell.Current.GoToAsync($"Page3?m1=שלום יב 10&&m2={vote}");
       Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "s1", student },
            { "m2", vote },
           { "m1", "שלום יב 10" }
        };
        await Shell.Current.GoToAsync("Page3", parameters);
    }
}