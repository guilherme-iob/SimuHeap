using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuHeap.Exceptions
{
    public class FalhaDeAlocacaoException : Exception
    {
        public FalhaDeAlocacaoException()
        {
        }

        public FalhaDeAlocacaoException(string message) : base(message)
        {
        }

        public FalhaDeAlocacaoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
