using Estoque.Exceptions;
using System;
using System.Runtime.Serialization;

namespace Estoque
{
    [Serializable]
    internal class ProdutoExistenteException : LeituraArquivoException
    {
        public ProdutoExistenteException()
        {
        }

        public ProdutoExistenteException(string message) : base(message) { }

    }
}