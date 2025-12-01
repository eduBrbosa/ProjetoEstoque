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

        public LeituraArquivoException(string message, Exception innerException) : base(message, innerException) { } 
    }
}
