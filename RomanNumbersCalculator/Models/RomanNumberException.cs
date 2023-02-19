using System;
using System.Runtime.Serialization;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumberException : Exception
    {
        public RomanNumberException()
        {
        }

        public RomanNumberException(string message) : base(message)
        {
        }

    }
}