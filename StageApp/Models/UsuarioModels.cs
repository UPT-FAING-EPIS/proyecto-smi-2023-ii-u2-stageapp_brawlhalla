using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = SQLite.MaxLengthAttribute;
namespace StageApp.Models;

[Table("Usuarios")]
public class UsuariosModels : BaseModels
{

    [MaxLength(50)]
    public string Nombre { get; set; } = "";

    [MaxLength(50)]
    public string Apellido { get; set; } = "";

    [MaxLength(10)]
    public string telefono { get; set; } = "";

    [MaxLength(50)]
    public string email { get; set; } = "";

    [MaxLength(100)]
    public string direccion { get; set; } = "";

    [MaxLength(50)]
    public string ciudad { get; set; } = "";

    [MaxLength(30)]
    public int equipo_id { get; set; } = 0;

    [MaxLength(30)]
    public int organizador_id { get; set; } = 0;

    public override string ToString() =>
    $"Id:{Id} - {Nombre} {Apellido} {telefono} {email} {direccion} {ciudad} {equipo_id} {organizador_id} ";
    
}



