using System;

namespace JRC.Exceptions
{
    internal class ApiKeyNotSetException : ArgumentException
    {
        public ApiKeyNotSetException(string message) : base(message) { }
    }
}
