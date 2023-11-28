using System.ComponentModel.DataAnnotations;

namespace StageApp.Models;

[Table("Equipos")]
public class EquiposModels : BaseModels
{

    [MaxLength(30)]
    public string Nombre { get; set; } = "";

    [MaxLength(30)]
    public string descripcion { get; set; } = "";

    [MaxLength(30)]
    public int torneo_id { get; set; } = 0;

    [MaxLength(30)]
    public int nro_miembros { get; set; } = 0;

    public override string ToString() =>
    $"Id:{Id} - {Nombre} {descripcion} {torneo_id} {nro_miembros}";

}

public abstract class BaseModels

{

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

}


