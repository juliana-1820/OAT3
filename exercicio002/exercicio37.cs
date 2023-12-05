using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio37
    {
        public void Executarexerciciotrintaesete()
        {


            //Faça um programa de conversão de base numérica. O programa deverá apresentar
            //uma tela de entrada com as seguintes opções: 1 - Adição. 2 - Subtração.
            //3 - Multiplicação. 4 - Divisão. Informe a opção: A partir da opção escolhida,
            //o programa deverá solicitar para que o usuário digite dois números.Em seguida,
            //o programa deve exibir o resultado da opção indicada pelo usuário e perguntar
            //ao usuário se ele deseja voltar ao menu principal.Caso a resposta seja 'S' ou
            //'s', deverá voltar ao menu, caso contrário deverá encerrar o programa.


            Console.WriteLine("Exercicio 37 - algoritmo de conversão de base numérica. ");
            Console.ReadKey();


            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.Write("Informe a opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Resultado: " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Resultado: " + (num1 * num2));
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine("Resultado: " + (num1 / num2));
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.Write("Deseja voltar ao menu principal? (S/N): ");
                string resposta = Console.ReadLine();
                if (resposta.ToLower() != "s")
                {
                    continuar = false;
                }
            }
        }
    }
}
