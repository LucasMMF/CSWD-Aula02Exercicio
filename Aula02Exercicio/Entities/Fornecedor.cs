using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Exercicio.Entities
{
    public class Fornecedor
    {
        #region Properties

        public Guid IdFornecedor { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        #endregion

        #region Associations

        public List<Produto> Produtos { get; set; }

        #endregion
    }
}
