﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DAL.Entities
{
    public class Country : AuditBase
    {
        [Display (Name = "Pais")]// para identificarlo mas facil
        [MaxLength(50, ErrorMessage = "El campo debe tener como mazimo 5o caracteres")]//maximo longitud
        [Required (ErrorMessage = "El campo {0} es obligstorio")]
        public string Name { get; set; }

    }
    public class Estate : AuditBase
    {
        [Display(Name = "Ciudad")]// para identificarlo mas facil
        [MaxLength(50, ErrorMessage = "El campo debe tener como mazimo 5o caracteres")]//maximo longitud
        [Required(ErrorMessage = "El campo {0} es obligstorio")]
        public string Name { get; set; }

    }
}
