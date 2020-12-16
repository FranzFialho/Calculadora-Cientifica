using System;
using CalculadoraSimples;

namespace CalculadoraSimples.Entities
{
    class Calculadora
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public Calculadora()
        {
        }

        public Calculadora(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public double Soma()
        {
            double soma = Valor1 + Valor2;
            return soma;
        }

        public double Subtracao()
        {
            double subtracao = Valor1 - Valor2;
            return subtracao;
        }

        public double Multiplicacao()
        {
            double multiplicacao = Valor1 * Valor2;
            return multiplicacao;
        }

        public double Divisao()
        {

            if (Valor2 == 0)
            {
                throw new CalculadoraException("Não ha divisão por ZERO...");
            }
            else
            {
                double divisao = Valor1 / Valor2;
                return divisao;
            }
        }

        public int RaizQuadrada(int num)
        {

            int raiz = (int)Math.Sqrt(num);

            if(Math.Pow(raiz,2) == num)
            {
                return raiz;
            }
            
            throw new CalculadoraException("\nO numero informado não existe raiz quadrada perfeita.");
        }

    }
}
