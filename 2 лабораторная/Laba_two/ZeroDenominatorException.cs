using System;

namespace Laba_two
{
    internal class ZeroDenominatorException : Exception
    {
        public override string Message
        {
            get
            {
                return "Коэффициент a = 0!";
            }
        }
    }
}