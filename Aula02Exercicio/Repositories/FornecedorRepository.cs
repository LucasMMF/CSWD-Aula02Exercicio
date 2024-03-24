using Aula02Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Exercicio.Repositories
{
    public class FornecedorRepository
    {
        public void Exportar(Fornecedor fornecedor)
        {

            var path = $"D:\\temp\\csharp\\webdeveloper\\fornecedor_{fornecedor.IdFornecedor}.txt";

            var streamWriter = new StreamWriter(path);

            #region Inserting information for fornecedor

            streamWriter.WriteLine($"ID.....................: {fornecedor.IdFornecedor}");
            streamWriter.WriteLine($"FORNECEDOR.............: {fornecedor.Nome}");
            streamWriter.WriteLine($"CNPJ...................: {fornecedor.Cnpj}");

            #endregion

            #region Inserting information for all associated produtos

            streamWriter.WriteLine("\n ***** PRODUTOS ASSOCIADOS ***** \n");
            foreach (var produto in fornecedor.Produtos)
            {
                streamWriter.WriteLine($"\nID.....................: {produto.IdProduto}");
                streamWriter.WriteLine($"NOME...................: {produto.Nome}");
                streamWriter.WriteLine($"PREÇO..................: {produto.Preco}");
                streamWriter.WriteLine($"QUANTIDADE.............: {produto.Quantidade}");
            }

            #endregion

            streamWriter.Flush();
            streamWriter.Close();

        }
    }
}
