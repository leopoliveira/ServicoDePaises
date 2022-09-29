using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoSOAP
{

    public class Cep
    {
        [Required]
        [MaxLength(9, ErrorMessage = "Cep tem que ser digitado no formato 70000-000")]
        [MinLength(9, ErrorMessage = "Cep tem que ser digitado no formato 70000-000")]
        public string Codigo { get; set; }
    }
    public class Endereco
    {
        public string Descricao { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }

}
