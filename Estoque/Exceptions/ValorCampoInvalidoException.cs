using Estoque.Exceptions;
using System;
using System.Runtime.Serialization;

namespace Estoque
{
    [Serializable]
    internal class ValorCampoInvalidoException : LeituraArquivoException
    {
        public ValorCampoInvalidoException()
        {
        }

        public ValorCampoInvalidoException(string message) : base(message) { }

    }
}