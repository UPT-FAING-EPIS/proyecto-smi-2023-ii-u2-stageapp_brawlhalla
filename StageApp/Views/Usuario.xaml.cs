namespace StageApp;
using Microsoft.Maui.Controls;

public partial class Usuario : ContentPage
{
	Button UsuariosButton;
	Button UsuariosButtonModificar;
	Button UsuariosButtonEliminar;
	Button UsuariosButtonListar;
	VerticalStackLayout layout;
	public Usuario()
	{
		 BindingContext = App.Current.Services.GetService<UsuarioViewModels>();
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
                new Label { Text = "Apellido", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
				new Label { Text = "Email", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
				new Entry (),
                new Label { Text = "Organizador", TextColor = Color.FromRgb(255, 255, 255) },
                new Entry ()
			}
        };

        UsuariosButtonModificar = new Button { Text = "Modificar Perfil", BackgroundColor = Color.FromRgb(179, 87, 141) };
        layout.Children.Add(UsuariosButtonModificar);

        Content = layout;


	}
}