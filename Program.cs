using CalculadoraSimples.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace CalculadoraSimples.Entities.Enuns
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            double n1, n2;

        retorna:
            try
            {
                Console.WriteLine("\t\t----------------------");
                Console.WriteLine("\t\tCalculadora Cientifica");
                Console.WriteLine("\t\t----------------------");

                Console.WriteLine("Escolha uma opção: \n");

                Console.WriteLine("1 - Somar +");
                Console.WriteLine("2 - Subtrair -");
                Console.WriteLine("3 - Multiplicar *");
                Console.WriteLine("4 - Dividir /");
                Console.WriteLine("5 - Raiz Quadrada √");
                Console.WriteLine("6 - Potência de um numero X²³");
                Console.WriteLine("7 - Valor de Delta, x'e x");
                Console.WriteLine("\n0 - Sair");
                Console.Write("\nOPCÃO => ");
                int opc = int.Parse(Console.ReadLine());

                if (Enum.IsDefined(typeof(OpcoesMenu), opc) == false) //Verifica se a variavel opc recebeu valores que correspodem a classe ENUM.
                {
                    Console.WriteLine("\nSomente Opções validas!!!");
                    Console.ReadKey();
                    Console.Clear();
                    goto retorna;
                }

                switch (opc)
                {
                    case 0:
                        Console.WriteLine("\nSaindo...");

                        Environment.Exit(1);
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\t##### " + OpcoesMenu.Somar + " #####");

                        Console.Write("\nPrimeiro Valor: ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Segundo Valor: ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Calculadora calc = new Calculadora(n1, n2);
                        calc.Soma();

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n\t##### " + OpcoesMenu.Subtrair + " #####");

                        Console.Write("\nPrimeiro Valor: ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Segundo Valor: ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        var subtr = new Calculadora(n1, n2);
                        subtr.Subtracao();

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n\t##### " + OpcoesMenu.Multiplicar + " #####");

                        Console.Write("\nPrimeiro Valor: ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Segundo Valor: ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        var multi = new Calculadora(n1, n2);
                        multi.Multiplicacao();

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n\t##### " + OpcoesMenu.Dividir + " #####");

                        Console.Write("\nPrimeiro Valor: ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Segundo Valor: ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        var divisao = new Calculadora(n1, n2);
                        divisao.Divisao();

                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n\t##### " + OpcoesMenu.Raiz_Quadrada + " #####");

                        Console.Write("\nQual numero deseja ver sua raiz quadrada: ");
                        int num = int.Parse(Console.ReadLine());

                        var raiz = new Calculadora();
                        raiz.RaizQuadrada(num);

                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n\t##### " + OpcoesMenu.Potencia + " #####");

                        Console.WriteLine("\nDigite um numero e um exponte para descobrir sua potência. ");
                        Console.Write("Numero => ");
                        int Valor = int.Parse(Console.ReadLine());
                        Console.Write("Potencia => ");
                        int Expoente = int.Parse(Console.ReadLine());

                        var potencia = new Calculadora();
                        potencia.Potencia(Valor, Expoente);

                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("\n\t##### " + OpcoesMenu.Delta + " #####");

                        Console.WriteLine("\nInforme os valores: ");
                        Console.Write("A: ");
                        int A = int.Parse(Console.ReadLine());
                        Console.Write("B: ");
                        int B = int.Parse(Console.ReadLine());
                        Console.Write("C: ");
                        int C = int.Parse(Console.ReadLine());

                        Calculadora delta = new Calculadora();
                        delta.Delta(A, B, C);

                        break;
                }

                Console.WriteLine("\nVoltar ao menu principal pressione ESC.\nPara Sair pressione N.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    goto retorna;
                }
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Console.WriteLine("Saindo....");
                    Environment.Exit(1);
                }
            }

            catch (FormatException) // Exception caso informe valores invalidos nas operações.
            {
                Console.WriteLine("\nERROR!!!\nPor favor, somente valores numericos.");
                Console.ReadKey();
                Console.Clear();
                goto retorna;
            }

            catch (CalculadoraException e)// Exception das operações
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Console.Clear();
                goto retorna;
            }

            

        }
    }
}













