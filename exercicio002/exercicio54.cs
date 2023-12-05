using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio54
    {
        public void Executarexerciciocinquentaequatro()
        {

            //Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C que
            //imprima todos os elementos comuns aos dois vetores. 



            Console.WriteLine("Exercicio 54 - algoritmo que imprima todos os elementos comuns aos dois vetores. ");
            Console.ReadKey();



            int[] A = new int[5];
            int[] B = new int[8];

            Console.WriteLine("Digite os elementos do vetor A:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor B:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                B[i] = int.Parse(Console.ReadLine());
            }

            List<int> comuns = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (A[i] == B[j] && !comuns.Contains(A[i]))
                    {
                        comuns.Add(A[i]);
                    }
                }
            }

            Console.WriteLine("Elementos comuns aos dois vetores:");
            foreach (int numero in comuns)
            {
                Console.WriteLine(numero);
                Console.ReadKey();
            }
        }
    }
}
