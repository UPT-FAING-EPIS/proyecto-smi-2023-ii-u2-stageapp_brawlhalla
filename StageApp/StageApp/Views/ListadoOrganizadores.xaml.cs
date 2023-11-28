namespace StageApp.Views;

public partial class ListadoOrganizadores : ContentPage
{
	public ListadoOrganizadores()
	{
		InitializeComponent();
		BindingContext = App.Current.Services.GetService<OrganizadoresViewModels>();
	}

    
}