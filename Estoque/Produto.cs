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

        public void AtualizarNome(string novoNome)
        {
            Nome = novoNome;
        }
        public void AtualizarPreco(double novoPreco)
        {
            Preco = novoPreco;
        }
        public void AtualizarCategoria(string novaCategoria)
        {
            Categoria = novaCategoria;
        }

        
            
    }
}
