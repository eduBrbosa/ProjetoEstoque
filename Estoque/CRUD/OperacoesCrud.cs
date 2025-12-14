using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Estoque.CRUD
{
    public class OperacoesCrud
    {
        public void ListarProdutos(List<Produto> produtos)
        {

            Console.WriteLine("Lista de produtos cadastrados");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Preço: R${produto.Preco}, Categoria: {produto.Categoria}");
            }

        }
        public void AdicionarProduto(List<Produto> produtos)
        {
            Console.WriteLine("Insira o nome do produto: ");
            string nomeAdicionar = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto: ");
            int precoAdicionar = int.Parse(Console.ReadLine().Replace(',', '.'));

            Console.WriteLine("Insira a categoria do produto: ");
            string categoriaAdicionar = Console.ReadLine();

            Produto novoProduto = new Produto(nomeAdicionar, precoAdicionar, categoriaAdicionar);
            
            produtos.Add(novoProduto);
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        public void RemoverProduto(List<Produto> produtos)
        {
            Console.WriteLine("Qual produto você gostaria de remover?");
            Produto produtoBucsar = BuscarProduto(produtos);

            if (produtoBucsar != null)
            {
                if(!produtoBucsar.ConfirmarAlteracao())
                {
                    Console.WriteLine("Voltando ...");
                    return;
                }

                produtos.Remove(produtoBucsar);
                Console.WriteLine("Produto removido com sucesso!");

            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }

        }


        public void AtualizarProduto(List<Produto> produtos)
        {
            Console.WriteLine("Qual produto você gostaria de atualizar?");
            Produto produtoBuscar = BuscarProduto(produtos);
            
            if(produtoBuscar != null)
                produtoBuscar.AtualizarProduto();

            else
            {
                Console.WriteLine("Produto não encontrado!");
                Thread.Sleep(2000);
                return;
            }
        }
        
        private static Produto BuscarProduto(List<Produto> produtos)
        {
            string nomeBusca = Console.ReadLine();

            Produto produtoBucsar = produtos.FirstOrDefault
                            (p => p.Nome.Equals
                            (nomeBusca, StringComparison.OrdinalIgnoreCase));
            return produtoBucsar;
        }


        
    }
}
