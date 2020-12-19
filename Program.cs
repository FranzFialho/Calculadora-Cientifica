using CalculadoraSimples.Entities;
using System;
using System.Globalization;

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

                Console.WriteLine("\t\t\tCalculadora Cientifica");

                Console.WriteLine("\tEscolha uma opção: \n");

                Console.WriteLine("1 - Somar +");
                Console.WriteLine("2 - Subtrair -");
                Console.WriteLine("3 - Multiplicar *");
                Console.WriteLine("4 - Dividir /");
                Console.WriteLine("5 - Raiz Quadrada √");
                Console.WriteLine("6 - Potência de um numero X²³");
                Console.WriteLine("7 - Valor de Delta, x'e x");
                Console.WriteLine("0 - Sair");
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

                        Console.WriteLine("\n\t##### " + OpcoesMenu.Somar + " #####");

                        Console.Write("\nPrimeiro Valor: ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Segundo Valor: ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        var calc = new Calculadora(n1, n2);
                        Console.WriteLine(calc.Soma());

                        break;

                    case 2:

                        Console.WriteLine("\n\t##### " + OpcoesMenu.Subtrair + " #####");

                        Console.Write("\nPrimeiro Valor: ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Segundo Valor: ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        var subtr = new Calculadora(n1, n2);
                        Console.WriteLine(subtr.Subtracao());

                        break;

                    case 3:

                        Console.WriteLine("\n\t##### " + OpcoesMenu.Multiplicar + " #####");

                        Console.Write("\nPrimeiro Valor: ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Segundo Valor: ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        var multi = new Calculadora(n1, n2);
                        Console.WriteLine(multi.Multiplicacao());

                        break;

                    case 4:

                        Console.WriteLine("\n\t##### " + OpcoesMenu.Dividir + " #####");

                        Console.Write("\nPrimeiro Valor: ");
                        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Segundo Valor: ");
                        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        var divisao = new Calculadora(n1, n2);
                        Console.WriteLine(divisao.Divisao());

                        break;


                    case 5:

                        Console.WriteLine("\n\t##### " + OpcoesMenu.Raiz_Quadrada + " #####");

                        Console.Write("\nQual numero deseja ver sua raiz quadrada: ");
                        int num = int.Parse(Console.ReadLine());

                        var raiz = new Calculadora();
                        Console.WriteLine(raiz.RaizQuadrada(num));

                        break;

                    case 6:

                        Console.WriteLine("\n\t##### " + OpcoesMenu.Potencia + " #####");
                        Console.WriteLine("\nDigite um numero e um exponte para descobrir sua potência. ");
                        Console.Write("Numero => ");
                        int Valor = int.Parse(Console.ReadLine());
                        Console.Write("Potencia => ");
                        int Expoente = int.Parse(Console.ReadLine());

                        var potencia = new Calculadora();
                        Console.WriteLine(potencia.Potencia(Valor, Expoente));

                        break;

                }
            }

            catch (FormatException) // Exception caso informe valores invalidos nas operações.
            {
                Console.WriteLine("\nERROR!!!\nPor favor, somente numeros validos.");
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
            catch (ArgumentNullException)//Exception do ENUM
            {
                Console.WriteLine("\nERROR!!!\nPor favor, somente opcoes numerais.");
                Console.ReadKey();
                Console.Clear();
                goto retorna;
            }

        opcao:
            try
            {
                Console.WriteLine("================================================");
                Console.WriteLine("\n1 - Deseja Continuar.\n2 - Deseja Sair.");
                Console.Write("OPÇÂO => ");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.Clear();
                    goto retorna;
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Saindo...");
                    Environment.Exit(1);
                }
                else
                {
                    Console.Clear();
                    goto opcao;
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Escolha uma opção valida!!!");
                Console.ReadKey();
                Console.Clear();
                goto opcao;
            }

        }
    }
}













