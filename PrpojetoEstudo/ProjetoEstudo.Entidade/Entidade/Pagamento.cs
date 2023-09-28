using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Entidade.Entidade
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public Produto Produto { get; set; }

        public int Id_Produto { get; set; }
    }
}
