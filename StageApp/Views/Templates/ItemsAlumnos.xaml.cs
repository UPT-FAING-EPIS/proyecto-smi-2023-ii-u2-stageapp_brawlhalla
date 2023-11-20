namespace Stage_App.Views.Templates;

public partial class ItemsOrganizadores : ContentView
{
	private readonly OrganizadoresViewModels viewmodel;
	public ItemsOrganizadores()
	{
		try
		{

		

		viewmodel = App.Current.Services.GetService<OrganizadoresViewModels>();
            InitializeComponent();
          //  BindingContext = viewmodel;

        }
        catch (Exception ex)
        {

            throw ex;
        }
        
	}
}