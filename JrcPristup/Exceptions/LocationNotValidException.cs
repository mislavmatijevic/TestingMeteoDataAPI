using System;

namespace JRC.Exceptions
{
    internal class LocationNotValidException : ArgumentException
    {
        public LocationNotValidException(string message) : base(message) { }
    }
}
