using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    public class Trabalhos
    {
        public int ID { get; set; }

        [Required (ErrorMessage ="Informe a Categoria")] public int idCategoria { get; set; }

        [Required (ErrorMessage ="Informe o Nome")] public string nome { get; set; }

        [Required (ErrorMessage = "Selecione uma ou mais fotos")]
        public List<string> fotos;
    }
}