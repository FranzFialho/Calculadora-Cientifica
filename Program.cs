using CalculadoraSimples.Entities;

using System;
using System.Globalization;



namespace CalculadoraSimples.Entities.Enuns
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2;
            int escolha;

        retorna:
            try
            {
                Console.WriteLine("\tCalculadora Simples, de contas Simples, para pessoas Simples =D");
                Console.WriteLine("\t\t\tEscolha uma opção: \n");

                Console.WriteLine("1 - Somar +");
                Console.WriteLine("2 - Subtrair -");
                Console.WriteLine("3 - Multiplicar *");
                Console.WriteLine("4 - Dividir /");
                Console.WriteLine("5 - Raiz Quadrada √");
                Console.WriteLine("6 - Potência de um numero X²³");
                Console.Write("\nOPCÃO => ");
                Enum opc = Enum.Parse<OpcoesMenu>(Console.ReadLine());
                //Descobrir uma forma do programa não reconhecer numeros alem dos definidos na classe Enum.
                if ( )
                {

                }

                Console.WriteLine("\n\t##### " + opc + " #####");

                Console.Write("\nPrimeiro Valor: ");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Segundo Valor: ");
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (opc)
                {

                    case OpcoesMenu.Somar:

                        Calculadora calc = new Calculadora(n1, n2);

                        Console.WriteLine("\nResultado da Soma = " + calc.Soma(), CultureInfo.InvariantCulture);
                        break;

                    case OpcoesMenu.Subtrair:

                        Calculadora subtr = new Calculadora(n1, n2);

                        Console.WriteLine("\nResultado da ubtração = " + subtr.Subtracao(), CultureInfo.InvariantCulture);
                        break;

                    case OpcoesMenu.Multiplicar:

                        Calculadora multi = new Calculadora(n1, n2);

                        Console.WriteLine("\nResultado da Multiplicação = " + multi.Multiplicacao(), CultureInfo.InvariantCulture);
                        break;


                    case OpcoesMenu.Dividir:

                        Calculadora divisao = new Calculadora(n1, n2);
                        double div = divisao.Divisao();

                        Console.WriteLine("\nResultado da Divisão = " + div.ToString("F2", CultureInfo.InvariantCulture));
                        break;


                    case OpcoesMenu.RaizQuadrada:


                        Console.Write("Qual numero deseja ver sua raiz quadrada: ");
                        int num = int.Parse(Console.ReadLine());

                        Calculadora raiz = new Calculadora();

                        Console.WriteLine($"\nA raiz quadrada de {num} é: " + raiz.RaizQuadrada(num));

                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("\nERROR!!!\nPor favor, somente numeros validos.");
                Console.ReadKey();
                Console.Clear();
                goto retorna;
            }
            catch (CalculadoraException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Console.Clear();
                goto retorna;
            }
            catch (ArgumentException)
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
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.Clear();
                    goto retorna;
                }
                else if (escolha == 2)
                {
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




