namespace StageApp.ViewModels;
public partial class OrganizadoresViewModels : ObservableObject
{
    private readonly IOrganizadores _Organizadoresservice;
    private readonly IDialogService _dialog;
    public ObservableCollection<OrganizadoresModels> Organizadores { get; set; } = new();

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsReady))]
    private bool isLoading;

    [ObservableProperty]
    bool isRefreshing;
    public bool IsReady => !IsLoading;


    public OrganizadoresViewModels()
    {
        _Organizadoresservice = App.Current.Services.GetService<IOrganizadores>();
        _dialog = App.Current.Services.GetService<IDialogService>();
        Task.Run(async () => await ListarOrganizadores());

    }


    [RelayCommand]
    public async Task ListarOrganizadores()
    {
        IsLoading = true;
        Organizadores.Clear();
        var lista = await _Organizadoresservice.GetAll();
        foreach (var item in lista) Organizadores.Add(item);
        IsLoading = false;
        IsRefreshing = false;
    }


    [RelayCommand]
    public async Task EditarOrganizador(OrganizadoresModels Organizador)
    {

        await Shell.Current.GoToAsync($"/Organizador?Id={Organizador.Id}&Nombre={Organizador.Nombre}&Apellido={Organizador.Apellido}", false);

    }

    [RelayCommand]
    public async Task EliminarOrganizador(OrganizadoresModels Organizador)
    {

        IsLoading = true;
        var res = await _dialog.ShowAlertAsync("Eliminar", $"Desea eliminiar el registro {Organizador.Id}", "Aceptar", "Cancelar");
        if (!res) return;
        var A = await _Organizadoresservice.DeleteOrganizador(Organizador);
        await ListarOrganizadores();

    }

    [RelayCommand]
    public async Task AddNew()
    {

        await Shell.Current.Navigation.PushAsync(new Organizador(), false);
    }


}
