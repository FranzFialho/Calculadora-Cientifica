using System;


namespace CalculadoraSimples.Entities
{
    class CalculadoraException : ArithmeticException
    {

        public CalculadoraException(string message) : base(message)
        {
            
        }

    }
}
