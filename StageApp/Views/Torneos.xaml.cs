namespace StageApp;

public partial class Torneos : ContentPage
{
    Button crearButton;
    VerticalStackLayout layout;

    public Torneos()
    {
        InitializeComponent();
        layout = new VerticalStackLayout
        {
            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 60, 30, 30),
            Children =
            {
                new Label { Text = "Crear Torneo", FontSize = 30, TextColor = Color.FromRgb(212, 102, 163) },
                new Label { Text = "Nombre", TextColor = Color.FromRgb(179, 87, 141) },
                new Entry (),
                new Label { Text = "Nro. Miembros", TextColor = Color.FromRgb(179, 87, 141) },
                new Entry ()
            }
        };
        crearButton = new Button { Text = "Crear Torneo", BackgroundColor = Color.FromRgb(179, 87, 141) };
        layout.Children.Add( crearButton );

        Content = layout;
    }

}