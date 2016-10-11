using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models
{
    public class Clientes
    {
        public int ID { get; set; }

        [DisplayName("Primeiro Nome")]
        [StringLength(50, ErrorMessage = "O campo Nome permite no máximo 50 caracteres!")]
        [Required] public string nome { get; set; }

        [DisplayName("Sobrenome")]
        [StringLength(50, ErrorMessage = "O campo Sobrenome permite no máximo 50 caracteres!")]
        [Required (ErrorMessage = "Informe o sobrenome")] public string sobrenome { get; set; }

        [DisplayName("Telefone")]
        [Required (ErrorMessage = "Informe o telefone")] public string telefone { get; set; }

        [DisplayName("Telefone")] public string endereco { get; set; }

        [DisplayName("Email")]
        [StringLength(50)]
        [Required(ErrorMessage = "Informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string email { get; set; }

        [DisplayName("Usuário")]
        [Required (ErrorMessage = "Informe o usuário")] public string usuario { get; set; }

        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        [Required (ErrorMessage = "Informe a senha")] public string senha { get;  set; }
    }
}