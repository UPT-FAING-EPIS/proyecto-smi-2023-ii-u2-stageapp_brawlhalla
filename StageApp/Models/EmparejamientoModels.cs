using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = SQLite.MaxLengthAttribute;

namespace StageApp.Models;

[Table("Emparejamiento")]
public class EmparejamientoModels : BaseModels
{

    [MaxLength(30)]
    public string Primer_equipo { get; set; } = "";

    [MaxLength(30)]
    public string Segundo_equipo { get; set; } = "";

    [MaxLength(30)]
    public string Torneo_id { get; set; } = "";

    [MaxLength(30)]
    public string Resultado_id { get; set; } = "";

    public override string ToString() =>
    $"Id:{Id} - {Primer_equipo} {Segundo_equipo} {Torneo_id} {Resultado_id}";
    
}

public abstract class BaseModels

{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

}


