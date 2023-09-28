using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Entidade.Entidade
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }

        public string NomePessoa { get; set; }

        public string EmailPessoa { get; set; }

        public string Sexo { get; set; }

        public string Cpf { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual Loja Loja { get; set; }
    }
}
