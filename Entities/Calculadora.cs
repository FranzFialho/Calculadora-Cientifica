﻿using System;
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

        }

        public void Soma()
        {
            
            double soma = Valor1 + Valor2;
           Console.WriteLine("\nResultado da soma = " + soma);
        }

        public void Subtracao()
        {
            double subtracao = Valor1 - Valor2;
            Console.WriteLine("\nResultado da  Subtração = " + subtracao);
        }

        public void Multiplicacao()
        {
            double multiplicacao = Valor1 * Valor2;
            Console.WriteLine("\nResultado da mutiplicação = " + multiplicacao);
        }

        public void Divisao()
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
                Console.WriteLine("\nResultado da Divisão = " + divisao.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        public void RaizQuadrada(int num)
        {

            int raiz = (int)Math.Sqrt(num);

            if (Math.Pow(raiz, 2) == num)
            {
                Console.WriteLine($"\nA raiz quadrada de {num} é {raiz}");
            }

            throw new CalculadoraException("\nO numero informado não existe raiz quadrada perfeita.");
        }

        public void Potencia(int num, int expoente)
        {

            int resul = (int)Math.Pow(num, expoente);

            Console.WriteLine($"\nO Valor de sua potência é = {resul}");

        }

        public void Delta(int a, int b, int c)
        {
            double delta = (Math.Pow(b, 2)) - 4 * a * c;

            Console.WriteLine("\nDELTA = B² - 4.a.b");
            if (-4 * a * c > 0)
            {
                Console.WriteLine($"DELTA = {b}² - 4 . {a} . {c}" +
                         "\nDELTA = " + Math.Pow(b, 2) + " + " + -4 * a * c +
                          "\nDELTA = " + delta);
            }

            if (-4 * a * c < 0)
            {
                Console.WriteLine($"\nDELTA = {b}² - 4 . {a} . {c}" +
                         "\nDELTA = " + Math.Pow(b, 2) + "" + -4 * a * c +
                          "\nDELTA = " + delta);
            }

            if (delta < 0)
            {
                Console.WriteLine("DELTA < 0, Não há reais... ");
            }

        }
    }
}


