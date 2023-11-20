namespace StageApp.Models;

[Table("Equipos")]
public class EquiposModels : BaseModels
{

    [MaxLength(30)]
    public string Nombre { get; set; } = "";
    
    public override string ToString() =>
    $"Id:{Id} - {Nombre}";
    
}


