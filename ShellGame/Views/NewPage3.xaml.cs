using ShellGame.Models;

namespace ShellGame.Views;

[QueryProperty(nameof(Message2),"m2")]
[QueryProperty(nameof(MessageFromPage2),"m1")]
[QueryProperty(nameof(Student), "s1")]
public partial class NewPage3 : ContentPage
{
	private Student student;
	public Student Student
	{
		get => student;
        set
		{
            student = value;
            OnPropertyChanged();
        }
    }
    private string message2;
	public string Message2 { get => message2;set
		{
			message2 = value;
			OnPropertyChanged();
		}
	}
	private string message;
	public string MessageFromPage2
    { 
		get
		{ return message; }
		set
		{ message = value;
			OnPropertyChanged();
		}
	}
	public NewPage3()
	{
		student = new Student
        {
            Name = " ",
            Age = 0,
            Educator = " "


        };
		BindingContext = this;
		InitializeComponent();
    }
}