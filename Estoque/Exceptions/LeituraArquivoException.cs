using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Exceptions
{
    public class LeituraArquivoException : Exception
    {
        public LeituraArquivoException()
        {
            
        }

        public LeituraArquivoException(string message) : base(message) { }

        public LeituraArquivoException(Exception innerException) : base("Ocorreu um erro durante a leitura do aqruivo!", innerException) { } 
    }
}
