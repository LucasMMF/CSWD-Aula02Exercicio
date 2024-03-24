using Aula02Exercicio.Entities;
using Aula02Exercicio.Repositories;
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

                Console.WriteLine("\n*** CADASTRO DE PRODUTO ***\n");

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

                #region Persists data captured into a .TXT file

                var produtoRepository = new ProdutoRepository();

                produtoRepository.Exportar(produto);

                #endregion

                #region Reports to the console that produto has been registered

                Console.WriteLine("\nPRODUTO CADASTRADO COM SUCESSO!\n");

                Console.WriteLine($"ID PRODUTO..............: {produto.IdProduto}");
                Console.WriteLine($"NOME DO PRODUTO.........: {produto.Nome}");
                Console.WriteLine($"PREÇO...................: {produto.Preco}");
                Console.WriteLine($"QUANTIDADE..............: {produto.Quantidade}");
                Console.WriteLine($"ID FORNECEDOR...........: {produto.Fornecedor.IdFornecedor}");
                Console.WriteLine($"FORNECEDOR..............: {produto.Fornecedor.Nome}");
                Console.WriteLine($"CNPJ....................: {produto.Fornecedor.Cnpj}");

                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao cadastrar o produto: {e.Message}");
            }
        }
    }
}
