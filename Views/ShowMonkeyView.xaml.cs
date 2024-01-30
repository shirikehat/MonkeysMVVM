using MonkeysMVVM.ViewModels;

namespace MonkeysMVVM.Views;

public partial class ShowMonkeyView : ContentPage
{
	public ShowMonkeyView()
	{
		InitializeComponent();
		this.BindingContext = new ShowMonkeyViewModel();
	}
}