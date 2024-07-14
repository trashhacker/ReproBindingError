using ReproBindingError.ViewModels;

namespace ReproBindingError.Views;

public partial class ApplicationPage : ContentPage
{
	public ApplicationPage(ApplicationViewModel instance)
	{
		InitializeComponent();
		BindingContext = instance;
	}
}