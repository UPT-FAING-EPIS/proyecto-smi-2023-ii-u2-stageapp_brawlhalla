namespace StageApp;

public partial class Login : ContentPage
{
    Button loginButton;
    VerticalStackLayout layout;
    public Login()
	{
		InitializeComponent();
        this.BackgroundColor = Color.FromArgb("3D487D");

        layout = new VerticalStackLayout
        {
            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 60, 30, 30),
            Children =
            {
                new Label { Text = "Iniciar Sesión", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label { Text = "Usuario", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
                new Label { Text = "Contraseña", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry { IsPassword = true }
            }
        };

        loginButton = new Button { Text = "Ingresar", BackgroundColor = Color.FromRgb(179, 87, 141) };
        layout.Children.Add(loginButton);

        Content = layout;

        loginButton.Clicked += (sender, e) =>
        {
            Navigation.PushAsync(new MainPage());
        };
    }
}