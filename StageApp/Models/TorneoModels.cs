using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = SQLite.MaxLengthAttribute;
namespace StageApp.Models;

[Table("Torneo")]
public class TorneoModels : BaseModels
{

    [MaxLength(50)]
    public string Nombre { get; set; } = "";

    [MaxLength(30)]
    public string Descripcion { get; set; } = "";

    [MaxLength(30)]
    public int Organizador_id { get; set; } = 0;

    [MaxLength(30)]
    public string fecha_inicio { get; set; } = "";

    [MaxLength(30)]
    public string fecha_fin { get; set; } = "";

    [MaxLength(30)]
    public string fases { get; set; } = "";

    public override string ToString() =>
    $"Id:{Id} - {Nombre} {Descripcion} {Organizador_id} {fecha_inicio} {fecha_fin} {fases} ";
    
}




