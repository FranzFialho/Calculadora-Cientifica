using System;
using CalculadoraSimples;
using System.Globalization;

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

            throw new FormatException ("\nSomente valore numerais !!!");
        }


        public string Soma()
        {
            double soma = Valor1 + Valor2;
            return "\nResultado da soma = " + soma;
        }

        public string Subtracao()
        {
            double subtracao = Valor1 - Valor2;
            return "\nResultado da  Subtração = " + subtracao;
        }

        public string Multiplicacao()
        {
            double multiplicacao = Valor1 * Valor2;
            return "\nResultado da mutiplicação = " + multiplicacao;
        }

        public string Divisao()
        {
            if (Valor1 < 0 || Valor2 < 0)
            {
                throw new CalculadoraException("\nNão ha divisão com numero negativo...");
            }

            if (Valor2 == 0)
            {
                throw new CalculadoraException("\nNão ha divisão por ZERO...");
            }
            else
            {
                double divisao = Valor1 / Valor2;
                return "\nResultado da Divisão = " + divisao.ToString("F2", CultureInfo.InvariantCulture);
            }
        }

        public string RaizQuadrada(int num)
        {

            int raiz = (int)Math.Sqrt(num);

            if (Math.Pow(raiz, 2) == num)
            {
                return $"\nA raiz quadrada de {num} é {raiz}";
            }

            throw new CalculadoraException("\nO numero informado não existe raiz quadrada perfeita.");
        }

        public string Potencia(int num,int expoente)
        {
            
            int resul = (int)Math.Pow(num, expoente);

            return $"\nO Valor de sua potência é = {resul}";

        }

        
    }
}
