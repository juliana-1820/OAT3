using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio52
    {
        public void Executarexerciciocinquentaedois()
        {
            //Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes
            //aparece o número 1, 3 e 4, nesta ordem.O vetor terá no máximo 100 posições.
            //Sair do programa quando for digitado - 1.


            Console.WriteLine("Exercicio 52 - algoritmo que imprima quantas vezes aparece o número 1, 3 e 4, nesta ordem em um vetor. ");
            Console.ReadKey();


            int[] vetor = new int[100];
            int contagem1 = 0, contagem3 = 0, contagem4 = 0;
            int numero;

            Console.WriteLine("Digite os elementos do vetor (digite -1 para parar):");

            for (int i = 0; i < 100; i++)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                {
                    break;
                }

                vetor[i] = numero;

                if (numero == 1)
                {
                    contagem1++;
                }
                else if (numero == 3)
                {
                    contagem3++;
                }
                else if (numero == 4)
                {
                    contagem4++;
                }
            }

            Console.WriteLine($"O número 1 aparece {contagem1} vezes.");
            Console.WriteLine($"O número 3 aparece {contagem3} vezes.");
            Console.WriteLine($"O número 4 aparece {contagem4} vezes.");
            Console.ReadKey();
        }
    }
}