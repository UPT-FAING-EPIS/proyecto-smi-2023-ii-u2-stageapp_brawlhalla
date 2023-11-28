﻿using System.ComponentModel.DataAnnotations;

namespace StageApp.Models;

[Table("Resultados")]
public class ResultadosModels : BaseModels
{

    [MaxLength(45)]
    public string equipo_id { get; set; } = "";


    public override string ToString() =>
    $"Id:{Id} - {equipo_id}";
    
}


