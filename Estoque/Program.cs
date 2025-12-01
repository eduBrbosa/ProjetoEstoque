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
            try
            {
                StreamReader();

            }
            catch(LeituraArquivoException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
