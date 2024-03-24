using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Exercicio.Entities
{
    public class Produto
    {
        #region Properties

        public Guid IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        #endregion

        #region Associations

        public Fornecedor Fornecedor { get; set; }

        #endregion
    }
}
