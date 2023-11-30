namespace StageApp;

public partial class Equipos : ContentPage
{
	 Button EquiposButton;
     Button EquiposButtonModificar;
     Button EquiposButtonEliminar;
     Button EquiposButtonListar;
    VerticalStackLayout layout;
	public Equipos()
	{
        BindingContext = App.Current.Services.GetService<EquiposViewModels>();
        InitializeComponent();
		this.BackgroundColor = Color.FromArgb("3D487D");
        layout = new VerticalStackLayout
        {
            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 60, 30, 30),
            Children =
            {
                new Label { Text = "Codigo", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
                new Label { Text = "Nombre", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
                new Label { Text = "Descripción", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),

            }
        };

        EquiposButton = new Button { Text = "Registrar", BackgroundColor = Color.FromRgb(179, 87, 141) };
        layout.Children.Add(EquiposButton);

        EquiposButtonModificar = new Button { Text = "Modificar", BackgroundColor = Color.FromRgb(179, 87, 141) };
        layout.Children.Add(EquiposButtonModificar);

        EquiposButtonEliminar = new Button { Text = "Eliminar", BackgroundColor = Color.FromRgb(179, 87, 141) };
        layout.Children.Add(EquiposButtonEliminar);

        EquiposButtonListar = new Button { Text = "Listar", BackgroundColor = Color.FromRgb(179, 87, 141) };
        layout.Children.Add(EquiposButtonListar);

        Content = layout;
	}
}