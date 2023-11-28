namespace StageApp.Views;

public partial class Organizador : ContentPage
{
	public Organizador()
	{
		BindingContext = App.Current.Services.GetService<OrganizadorViewModels>();
		InitializeComponent();

	}
}
