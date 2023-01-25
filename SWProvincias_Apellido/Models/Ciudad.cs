using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWProvincias_Apellido.Models
{
    public class Ciudad
    {
        [Key]
        public int IdCiudad { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set;  }

        [Required]
        [Column(TypeName = "int")]
        public int ProvinciaId { get; set;  }

        [ForeignKey("ProvinciaId")]
        public Provincia Provincia { get; set;  }
    }
}
