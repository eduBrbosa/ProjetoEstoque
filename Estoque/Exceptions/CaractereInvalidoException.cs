using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Exceptions
{
    public class CaractereInvalidoException : LeituraArquivoException
    {
        public CaractereInvalidoException()
        {
            
        }

        public CaractereInvalidoException(string message) : base(message) { }
    }
}
