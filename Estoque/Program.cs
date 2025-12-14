using Estoque.CRUD;
using Estoque.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Estoque
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Console.WriteLine("Fazendo a leitura do arquivo . . .");
            produtos = StreamReader();
            Thread.Sleep(3000);
            Console.Clear();
            
            OperacoesCrud crud = new OperacoesCrud();
            int escolha;

            do
            {
                Console.WriteLine(@"   ('-.    .-')    .-') _                     .-')                    ('-.   
 _(  OO)  ( OO ). (  OO) )                  .(  OO)                 _(  OO)  
(,------.(_)---\_)/     '._  .-'),-----.   (_)---\_)   ,--. ,--.   (,------. 
 |  .---'/    _ | |'--...__)( OO'  .-.  '  '  .-.  '   |  | |  |    |  .---' 
 |  |    \  :` `. '--.  .--'/   |  | |  | ,|  | |  |   |  | | .-')  |  |     
(|  '--.  '..`''.)   |  |   \_) |  |\|  |(_|  | |  |   |  |_|( OO )(|  '--.  
 |  .--' .-._)   \   |  |     \ |  | |  |  |  | |  |   |  | | `-' / |  .--'  
 |  `---.\       /   |  |      `'  '-'  '  '  '-'  '-.('  '-'(_.-'  |  `---. 
 `------' `-----'    `--'        `-----'    `-----'--'  `-----'     `------' ");


                Console.WriteLine("\n O que você gostaria de fazer? " +
                                  "\n 1. Listar produtos do estoque" +
                                  "\n 2. Adicionar novo produto" +
                                  "\n 3. Atualizar produto" +
                                  "\n 4. Remover produto" +
                                  "\n 0. Sair");

                escolha = int.Parse(Console.ReadLine());

            
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        crud.ListarProdutos(produtos);
                        Thread.Sleep(1000);
                        Console.WriteLine("Pressione qualquer tecla para retornar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        crud.AdicionarProduto(produtos);
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        crud.AtualizarProduto(produtos);
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        crud.RemoverProduto(produtos);
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 0:
                        Console.WriteLine("Finalizando . . . ");
                        Thread.Sleep(1000);
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            }
            while (escolha != 0);




            

        }

    }
}
