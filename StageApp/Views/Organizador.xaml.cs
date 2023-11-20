namespace Stage_App.Views;

public partial class organizador : ContentPage
{
	public organizador()
	{
		BindingContext = App.Current.Services.GetService<organizadorViewModels>();
		InitializeComponent();

	}
}
