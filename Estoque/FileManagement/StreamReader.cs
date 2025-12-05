using Estoque.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Estoque
{
    partial class Program
    {
        static List<Produto> StreamReader()
        {
            List<Produto> produtosRetorno = new List<Produto>();
            var enderecoArquivo = "produtos_3.csv";
            using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            {
                var leitor = new StreamReader(fluxoArquivo);

                string cabecalho = leitor.ReadLine();


                while (!leitor.EndOfStream)
                {

                    var linha = leitor.ReadLine();
                    
                    try
                    {
                        var produto = ConverteStringParaProduto(linha, produtosRetorno);
                        produtosRetorno.Add(produto);
                        Console.WriteLine($"Produto {produto.Nome} adicionado!");

                    }
                    catch (LeituraArquivoException ex)
                    {
                        Console.WriteLine($"{ex.Message}({ex.InnerException.Message})");
                    }
                    
                }

                return produtosRetorno;
            }
        }

        static Produto ConverteStringParaProduto(string linha, List<Produto> produtosRetorno)
        {

            string linhaFormatada = linha.TrimEnd(',');
            var campos = linhaFormatada.Split(',');

            if (campos.Count() != 3)
                throw new LeituraArquivoException(new QuantidadeCamposInvalidaException("Quantidade de campos inválida para o objeto!"));
            
            foreach (var obj in campos)
            {
                if (string.IsNullOrWhiteSpace(obj))
                    throw new LeituraArquivoException(new CampoVazioException("O campo lido não pode estar vazio!"));
                if (obj.Contains('"'))
                    throw new LeituraArquivoException(new CaractereInvalidoException("Caractére inválido verificado na leitura do arquivo!"));
            }


            var nome = campos[0];
            var preco = campos[1].Replace('.', ',');
            if (!double.TryParse(preco, out double precoDouble))
                throw new LeituraArquivoException(new FormatoObjetoInvalidoException("Formato do campo é inválido para o objeto!"));
            
            var categoria = campos[2];

            if (ValidaProdutoExistente(nome, produtosRetorno))
                throw new LeituraArquivoException(new ProdutoExistenteException("O produto já foi adicionado!"));
            if (precoDouble <= 0)
                throw new LeituraArquivoException(new ValorCampoInvalidoException("O valor do campo é inválido!"));

            Produto produto = new Produto(nome, precoDouble, categoria);

            return produto;

        }

        static bool ValidaProdutoExistente(string nomeProduto, List<Produto> produtos)
        {
            var querry = produtos.Where(p => p.Nome.Equals(nomeProduto));

            if (!querry.Any())
            {
                return false;
            }

            return true;
        }

    }
}