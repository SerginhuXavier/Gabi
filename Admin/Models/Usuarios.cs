using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    public class Usuarios
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe o nome de usuário")]
        public string usuario { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Informe a senha")]
        public string senha { get; set; }
    }
}