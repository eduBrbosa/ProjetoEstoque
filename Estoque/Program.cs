using Estoque.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos = StreamReader();

            //foreach (Produto produto in produtos)
            //    Console.WriteLine(produto.Nome);

            Console.ReadLine();
        }
    }
}
