using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaWebRecetas.Validations;

namespace SistemaWebRecetas.Models
{
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        [ValidCategoriaAttribute]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Ingredientes { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Instrucciones { get; set;}
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Apellido { get; set; }

        [MayorEdadAtributte]
        public int Edad { get; set; }

        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [EmailAddress(ErrorMessage ="Email no valido")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Email { get; set; }

    }
}
