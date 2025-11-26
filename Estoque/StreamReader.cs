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

                leitor.ReadLine();

                while (!leitor.EndOfStream)
                {
                    
                    var linha = leitor.ReadLine();
                   
                    try
                    {
                        var produto = ConverteStringParaProduto(linha);
                        Console.WriteLine(produto.Nome);    
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        linha.Skip(1);
                    }

                }
            }
        }

        static Produto ConverteStringParaProduto(string linha)
        {

            var campos = linha.Split(',');

            foreach(var obj in campos)
            {
                if(obj.Contains('"'))
                {
                    throw new Exception();
                }
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