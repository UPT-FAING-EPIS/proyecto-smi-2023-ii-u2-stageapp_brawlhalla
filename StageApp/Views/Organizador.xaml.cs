namespace StageApp.Views;

public partial class Organizador : ContentPage
{
	Button OrganizadorButton;
    VerticalStackLayout layout;
    public Organizador()
	{
		BindingContext = App.Current.Services.GetService<OrganizadorViewModels>();
		InitializeComponent();
        this.BackgroundColor = Color.FromArgb("3D487D");

        layout = new VerticalStackLayout
        {
            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 60, 30, 30),
            Children =
            {
                new Label { Text = "Id", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label { Text = "Usuario", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
            }
        };

        OrganizadorButton = new Button { Text = "Ingresar", BackgroundColor = Color.FromRgb(179, 87, 141) };
        layout.Children.Add(OrganizadorButton);

        Content = layout;

        OrganizadorButton.Clicked += (sender, e) =>
        {
            Navigation.PushAsync(new MainPage());
        };

	}
}
