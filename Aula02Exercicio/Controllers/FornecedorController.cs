using Aula02Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02Exercicio.Controllers
{
    public class FornecedorController
    {
        public void CadastrarFornecedor()
        {
            try
            {
                Console.WriteLine("\n*** CADASTRO DE FORNECEDOR ***");

                #region Capture data for fornecedor

                Fornecedor fornecedor = new Fornecedor();
                fornecedor.IdFornecedor = Guid.NewGuid();

                Console.Write("NOME DO FORNECEDOR.........: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ.......................: ");
                fornecedor.Cnpj = Console.ReadLine();

                #endregion

                #region Capture data for produtos

                bool continua = false;
                fornecedor.Produtos = new List<Produto>();

                do
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Guid.NewGuid();

                    Console.Write("NOME DO PRODUTO............: ");
                    produto.Nome = Console.ReadLine();

                    Console.Write("PRECO......................: ");
                    produto.Preco = decimal.Parse(Console.ReadLine());

                    Console.Write("QUANTIDADE.................: ");
                    produto.Quantidade = Int32.Parse(Console.ReadLine());

                    fornecedor.Produtos.Add(produto);

                    Console.Write("Deseja adicionar outro produto? (S/N): ");
                    continua = Console.ReadLine().ToUpper() == "S";
                } while (continua);

                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao cadastrar fornecedor: {e.Message}");
            }
        }
    }
}
