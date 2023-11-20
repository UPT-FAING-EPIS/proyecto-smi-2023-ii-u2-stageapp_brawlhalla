namespace StageApp.ViewModels;
public partial class EquiposViewModels : ObservableObject
{
    private readonly IEquipos _Equiposservice;
    private readonly IDialogService _dialog;
    public ObservableCollection<EquiposModels> Equipos { get; set; } = new();

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsReady))]
    private bool isLoading;

    [ObservableProperty]
    bool isRefreshing;
    public bool IsReady => !IsLoading;


    public EquiposViewModels()
    {
        _Equiposservice = App.Current.Services.GetService<IEquipos>();
        _dialog = App.Current.Services.GetService<IDialogService>();
        Task.Run(async () => await ListarEquipos());

    }


    [RelayCommand]
    public async Task ListarEquipos()
    {
        IsLoading = true;
        Equipos.Clear();
        var lista = await _Equiposservice.GetAll();
        foreach (var item in lista) Equipos.Add(item);
        IsLoading = false;
        IsRefreshing = false;
    }


    [RelayCommand]
    public async Task EditarEquipo(EquiposModels equipo)
    {

        await Shell.Current.GoToAsync($"/equipo?Id={equipo.Id}&Nombre={equipo.Nombre}", false);

    }

    [RelayCommand]
    public async Task Eliminarequipo(EquiposModels equipo)
    {

        IsLoading = true;
        var res = await _dialog.ShowAlertAsync("Eliminar", $"Desea eliminiar el registro {equipo.Id}", "Aceptar", "Cancelar");
        if (!res) return;
        var A = await _Equiposservice.DeleteEquipo(equipo);
        await ListarEquipos();

    }

    [RelayCommand]
    public async Task AddNew()
    {

        await Shell.Current.Navigation.PushAsync(new Equipos(), false);
    }


}
