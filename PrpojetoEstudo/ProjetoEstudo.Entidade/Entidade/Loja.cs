using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Entidade.Entidade
{
    public class Loja
    {
        public int IdLoja { get; set; }

        public string Nomeloja { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}
