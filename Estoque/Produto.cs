using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }

        public Produto(string nome, double preco, string categoria)
        {
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }

        public void AtualizarProduto()
        {
            Console.WriteLine("Qual informação do produto você gostaria de alterar?");
            Console.WriteLine("1. Nome \n" +
                              "2. Preço \n" +
                              "3. Categoria \n");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Insira o novo nome do produto: ");
                    string novoNome = Console.ReadLine();
                    
                    if (!ConfirmarAlteracao())
                        break;
                    
                    Nome = novoNome;
                    Console.WriteLine("Nome do produto alterado com sucesso!");
                    break;

                case 2:
                    Console.WriteLine("Insira o novo preço: ");
                    double novoPreco = double.Parse(Console.ReadLine());
                    
                    if (!ConfirmarAlteracao())
                        break;

                    Preco = novoPreco;
                    Console.WriteLine("Preço do produto alterado com sucesso!");
                    break;

                case 3:
                    Console.WriteLine("Insira a nova categoria do produto: ");
                    string novaCategoria = Console.ReadLine();

                    if (!ConfirmarAlteracao())
                        break;

                    Categoria = novaCategoria;
                    Console.WriteLine("Categoria do produto alterado com sucesso!");
                    break;
            }

        }


        public bool ConfirmarAlteracao()
        {
            Console.WriteLine("Tem certeza que deseja realizar a alteração?");
            Console.WriteLine("1. Sim\n" +
                              "2. Não");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha != 1)
            {
                Console.WriteLine("Cancalando operação");
                return false;
                
            }

            return true;
        }

       


    }
}
