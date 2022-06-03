using System;

namespace JrcPristup.Exceptions
{
    internal class JrcParameterException : ArgumentException
    {
        public JrcParameterException(string message) : base(message) { }
    }
}
