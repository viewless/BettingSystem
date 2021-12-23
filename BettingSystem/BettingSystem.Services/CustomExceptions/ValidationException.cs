using System;

namespace BettingSystem.Services.CustomExceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : base() { }

        public ValidationException(string message) : base(message) { }
    }
}
