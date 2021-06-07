using System;

namespace Obligatorio1_DA1.Exceptions
{
    public abstract class ValidationException : Exception
    {
        protected string messageToDisplay;
        public override string Message => this.messageToDisplay;
    }
}
