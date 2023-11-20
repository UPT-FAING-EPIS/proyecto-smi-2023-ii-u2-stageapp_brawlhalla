using System.Diagnostics;
using Microsoft.Maui.Controls;


namespace StageApp;

public partial class MainPage : TabbedPage
{
    public MainPage()
    {
        Children.Add(new Usuario { Title = "Usuario" });
        Children.Add(new Torneos { Title = "Torneos" });
        Children.Add(new Equipos { Title = "Equipos" });
    }
}

