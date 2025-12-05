using Estoque.Exceptions;
using System;
using System.Runtime.Serialization;

namespace Estoque
{
    [Serializable]
    public class QuantidadeCamposInvalidaException : LeituraArquivoException
    {
        public QuantidadeCamposInvalidaException()
        {
        }

        public QuantidadeCamposInvalidaException(string message) : base(message) { }
        
    }
}