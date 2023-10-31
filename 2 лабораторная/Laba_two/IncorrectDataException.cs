using System;

namespace Laba_two
{
    internal class IncorrectDataException : Exception
    {
        public override string Message
        {
            get
            {
                return "Некорректные данные!";
            }
        }
    }
}