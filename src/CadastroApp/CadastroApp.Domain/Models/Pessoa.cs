using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroApp.Domain.Models
{
    public class Pessoa
    {
        public string IdPessoa { get; set; }
        public string Nome { get; set; }                                   //show na listagem
        //public string Sobrenome { get; set; }                            //show na listagem
        //public string CPF { get; set; } // 11 DIGITOS
        //public DateTime DataNascimento { get; set; } // mais de 18 anos //show na listagem
        public string Genero { get; set; }
        //public Endereco Endereco { get; set; }                          //show na listagem (com ToString)
    }
}
