using Aula02Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Exercicio.Controllers
{
    public class ProdutoController
    {
        public void CadastrarProduto()
        {
            try
            {

                Console.WriteLine("\n*** CADASTRO DE PRODUTO ***");

                #region Capture data for produto

                Produto produto = new Produto();
                produto.IdProduto = Guid.NewGuid();

                Console.Write("NOME DO PRODUTO.........: ");
                produto.Nome = Console.ReadLine();

                Console.Write("PRECO...................: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("QUANTIDADE..............: ");
                produto.Quantidade = Int32.Parse(Console.ReadLine());

                #endregion

                #region Capture data for fornecedor

                produto.Fornecedor = new Fornecedor();
                produto.Fornecedor.IdFornecedor = Guid.NewGuid();

                Console.Write("NOME DO FORNECEDOR......: ");
                produto.Fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ....................: ");
                produto.Fornecedor.Cnpj = Console.ReadLine();

                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao cadastrar: {e.Message}");
            }
        }
    }
}
