namespace StageApp.Models;

[Table("Organizadores")]
public class OrganizadoresModels : BaseModels
{

    [MaxLength(30)]
    public string Nombre { get; set; } = "";

    [MaxLength(30)]
    public string Apellido { get; set; } = "";
    
    public override string ToString() =>
    $"Id:{Id} - {Nombre} {Apellido}";
    
}

