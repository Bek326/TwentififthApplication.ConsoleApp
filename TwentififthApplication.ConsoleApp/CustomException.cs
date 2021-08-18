using System;

namespace TwentififthApplication.ConsoleApp
{
    internal class CustomException : Exception
    {
        internal CustomException(string message) : base(message)
        {
        }
    }
}
