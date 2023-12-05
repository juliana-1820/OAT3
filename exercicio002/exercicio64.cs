using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio64
    {
        static int[] vetor = new int[10];
        static int opcao;

        public void Executarexerciciosessentaequatro()
        {


            //Escreva um programa que deverá ter as seguintes opções: 
            //1 - Carregar Vetor
            //2 - Listar Vetor
            //3 - Exibir apenas os números pares do vetor
            //4 - Exibir apenas os números ímpares do vetor
            //5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
            //6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
            //7 - Sair
            //Deverá ser implementado um método para realizar cada uma das opções de 1 a 6.


            Console.WriteLine("Exercicio 64 - programa vetor = método. ");
            Console.ReadKey();


            do
            {
                Console.WriteLine("1 - Carregar vetor");
                Console.WriteLine("2 - Listar vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
                Console.WriteLine("7 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        ListarVetor();
                        break;
                    case 3:
                        ExibirPares();
                        break;
                    case 4:
                        ExibirImpares();
                        break;
                    case 5:
                        ExibirParesPosicoesImpares();
                        break;
                    case 6:
                        ExibirImparesPosicoesPares();
                        break;
                    case 7:

                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.ReadKey();

            } while (opcao != 7);
        }

        public static void CarregarVetor()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um número para a posição " + i + ": ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

            }
        }

        public static void ListarVetor()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Posição " + i + ": " + vetor[i]);

            }
        }

        public static void ExibirPares()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine("Posição " + i + ": " + vetor[i]);

                }
            }
        }

        public static void ExibirImpares()
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine("Posição " + i + ": " + vetor[i]);

                }
            }
        }

        public static void ExibirParesPosicoesImpares()
        {
            int count = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 != 0 && vetor[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Quantidade de números pares nas posições ímpares: " + count);

        }

        public static void ExibirImparesPosicoesPares()
        {
            int count = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i % 2 == 0 && vetor[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Quantidade de números ímpares nas posições pares: " + count);
        }
    }
}