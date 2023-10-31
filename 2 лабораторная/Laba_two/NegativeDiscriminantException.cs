using System;

namespace Laba_two
{
    internal class NegativeDiscriminantException : Exception
    {
        public override string Message
        {
            get
            {
                return "Дискриминант D < 0!";
            }
        }
    }
}