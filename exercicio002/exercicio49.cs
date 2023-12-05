using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio49
    {
        public void Executarexercicioquarentaenove()
        {
            //Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50).
            //Determine e imprima quantas vezes que V1 e V2 possuem valores idênticos
            //nas mesmas posições. 


            Console.WriteLine("Exercicio 49 - algoritmo que leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50) ");
            Console.ReadKey();


            int[] V1 = new int[50];
            int[] V2 = new int[50];
            int N, contagem = 0;

            Console.Write("Digite o número de componentes nos vetores (no máximo 50): ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os elementos do vetor V1:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                V1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor V2:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                V2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                if (V1[i] == V2[i])
                {
                    contagem++;
                }
            }

            Console.WriteLine($"V1 e V2 possuem valores idênticos nas mesmas posições {contagem} vezes.");
            Console.ReadKey();
        }
    }
}