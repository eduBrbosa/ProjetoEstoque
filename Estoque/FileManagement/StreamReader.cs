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
        static void StreamReader()
        {
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
                        var produto = ConverteStringParaProduto(linha);
                        Console.WriteLine(produto.Nome);    
                    }
                    catch (CampoVazioException ex)
                    {

                        throw new LeituraArquivoException("Ocorreu um erro durante a leitura do aqruivo!", ex);
                    }
                    catch (CaractereInvalidoException ex)
                    {

                        throw new LeituraArquivoException("Ocorreu um erro durante a leitura do aqruivo!", ex);
                    }

                }
            }
        }

        static Produto ConverteStringParaProduto(string linha)
        {

            string linhaFormatada = linha.TrimEnd(',');
            var campos = linhaFormatada.Split(',');

            foreach (var obj in campos)
            {
                if (string.IsNullOrWhiteSpace(obj))
                    throw new CampoVazioException("O campo lido não pode estar vazio!");
                if (obj.Contains('"'))
                    throw new CaractereInvalidoException("Caractére inválido verificado na leitura do arquivo");


            }
            

            var nome = campos[0];
            var preco = campos[1].Replace('.', ',');
            var categoria = campos[2];

                        
            var precoDouble = double.Parse(preco);
             
            

            Produto produto = new Produto(nome, precoDouble, categoria);

            return produto;

        }
    }
}