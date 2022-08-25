using System;

namespace JRC.Exceptions
{
    internal class JrcParameterException : ArgumentException
    {
        public JrcParameterException(string message) : base(message) { }
    }
}
