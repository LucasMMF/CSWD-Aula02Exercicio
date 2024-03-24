using Aula02Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Exercicio.Repositories
{
    public class ProdutoRepository
    {
        public void Exportar(Produto produto)
        {

            var path = $"D:\\temp\\csharp\\webdeveloper\\produto_{produto.IdProduto}.txt";

            var streamWriter = new StreamWriter(path);

            #region Inserting information for produto

            streamWriter.WriteLine($"ID.....................: {produto.IdProduto}");
            streamWriter.WriteLine($"NOME...................: {produto.Nome}");
            streamWriter.WriteLine($"PREÇO..................: {produto.Preco}");
            streamWriter.WriteLine($"QUANTIDADE.............: {produto.Quantidade}");

            #endregion

            #region Inserting information for associated fornecedor

            streamWriter.WriteLine("\n ***** FORNECEDOR ASSOCIADO ***** \n");
            streamWriter.WriteLine($"ID.....................: {produto.Fornecedor.IdFornecedor}");
            streamWriter.WriteLine($"FORNECEDOR.............: {produto.Fornecedor.Nome}");
            streamWriter.WriteLine($"CNPJ...................: {produto.Fornecedor.Cnpj}");

            #endregion

            streamWriter.Flush();
            streamWriter.Close();

        }
    }
}
