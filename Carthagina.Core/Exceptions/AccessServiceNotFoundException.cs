using System;

namespace Carthagina.Core.Exceptions
{
    public class AccessServiceNotFoundException : Exception
    {
        public AccessServiceNotFoundException(string message) : base(message)
        {
        }
    }
}