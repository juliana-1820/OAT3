using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio23
    {
        public void Executarexerciciovinteetres()
        {

            //)Escreva um programa que exiba as seguintes opções e realize os que se
            //pede em cada uma delas: 1 - Adição. 2 - Subtração. 3 - Multiplicação.
            //4 - Divisão

            Console.WriteLine("Exercicio 23 - algoritmo menu soma, subtração, multiplicaão e divisão.");
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case 4:
                        if (num2 != 0)
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        else
                            Console.WriteLine("Erro: Divisão por zero.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}

