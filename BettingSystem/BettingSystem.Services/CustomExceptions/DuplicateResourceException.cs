using System;

namespace BettingSystem.Services.CustomExceptions
{
    public class DuplicateResourceException : Exception
    {
        public DuplicateResourceException() : base() { }

        public DuplicateResourceException(string message) : base(message) { }
    }
}
