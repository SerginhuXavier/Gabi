using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Categorias
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Informe o Nome")] public string Nome { get; set; }
    }
}