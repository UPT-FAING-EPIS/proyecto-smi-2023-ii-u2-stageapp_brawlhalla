namespace StageApp;

public partial class Equipos : ContentPage
{
	public Equipos()
	{
        BindingContext = App.Current.Services.GetService<EquiposViewModels>();
        InitializeComponent();
	}
}