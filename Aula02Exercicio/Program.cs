using Aula02Exercicio.Controllers;

namespace Aula02Exercicio
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("*** EXERCÍCIO AULA 02 ***");

            ProdutoController produtoController = new ProdutoController();
            FornecedorController fornecedorController = new FornecedorController();

            produtoController.CadastrarProduto();
            fornecedorController.CadastrarFornecedor();

            Console.ReadKey();

        }
    }
}