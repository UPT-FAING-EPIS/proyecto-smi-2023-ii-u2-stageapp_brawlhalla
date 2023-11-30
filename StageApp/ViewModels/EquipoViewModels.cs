using System.ComponentModel.DataAnnotations;

using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;

namespace StageApp.ViewModels;
[QueryProperty("TorneoID", "TorneoID")]
[QueryProperty("Nro_Miembros", "Nro_Miembros")]
[QueryProperty("Descripcion", "Descripcion")]
[QueryProperty("Nombre","Nombre")]
[QueryProperty("Id", "Id")]
public partial class EquipoViewModels : ObservableValidator
{
    private readonly IEquipos equipo_service;

    
    public ObservableCollection<string> Errores { get; set; }=new();
    
    [ObservableProperty]
    private string resultado;

    [ObservableProperty]
    private bool isBusy;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsEnabled))]
    private bool isVisible;
    public bool IsEnabled =>!IsVisible;

    [ObservableProperty]
    private int id;

    private string nombre;
    [Required(ErrorMessage = "El campo nombre es obligatorio")]
    [MaxLength(30)]
    public string Nombre
    {
        get => nombre;
        set => SetProperty(ref nombre, value, true);
    }
    
    public EquipoViewModels()
    => this.equipo_service = App.Current.Services.GetService<IEquipos>();

    [RelayCommand]
    public async Task GuardarEquipo(EquiposModels A)
    {
        IsBusy = true;
        IsVisible = false;
        ValidateAllProperties();

        Errores.Clear();
        GetErrors(nameof(Nombre)).ToList().ForEach(f => Errores.Add("Nombre:" + f.ErrorMessage));
        IsBusy = false;
        if (Errores.Count > 0) return;


        IsBusy = true;
        if (Id == 0) Id = await equipo_service.InsertEquipo(new EquiposModels() { Nombre = Nombre });
        if (Id > 0) await equipo_service.UpdateEquipo(new EquiposModels() { Nombre = Nombre, Id = Id });

        Resultado = $" Registro id:{Id}";
        IsBusy = false;
        IsVisible = true;

        await Task.Delay(2000);
        await Shell.Current.Navigation.PopToRootAsync();

    }
}

