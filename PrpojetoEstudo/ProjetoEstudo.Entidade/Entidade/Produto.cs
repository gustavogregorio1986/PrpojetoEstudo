using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Entidade.Entidade
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public List<Loja> Lojas { get; set; }

        public int Id_Loja { get; set; }

        public virtual Pagamento Pagamento { get; set; }
    }
}
