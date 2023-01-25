using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Collections.Generic;

namespace SWProvincias_Apellido.Models
{
    public class Provincia
    {
        [Key]
        public int IdProvincia { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        public List<Ciudad> Ciudades { get; set; }
    }
}
