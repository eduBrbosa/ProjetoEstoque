using Estoque.Exceptions;
using System;
using System.Runtime.Serialization;

namespace Estoque
{
    [Serializable]
    public class FormatoObjetoInvalidoException : LeituraArquivoException
    {
        public FormatoObjetoInvalidoException()
        {
        }

        public FormatoObjetoInvalidoException(string message) : base(message) { }

    }
}