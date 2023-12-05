using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio56
    {
        public void Executarexerciciocinquentaeseis()
        {
            //Fazer um programa para ler um vetor de inteiros positivos de 50 posições.
            //Imprimir a quantidade de números pares e de múltiplos de 5.


            Console.WriteLine("Exercicio 56 - programa para imprimir a quantidade de números pares e de múltiplos de 5. ");
            Console.ReadKey();



            int[] vetor = new int[50];
            int contagemPares = 0, contagemMultiplos5 = 0;

            Console.WriteLine("Digite os elementos do vetor:");
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    contagemPares++;
                }

                if (vetor[i] % 5 == 0)
                {
                    contagemMultiplos5++;
                }
            }

            Console.WriteLine($"A quantidade de números pares no vetor é: {contagemPares}");
            Console.WriteLine($"A quantidade de múltiplos de 5 no vetor é: {contagemMultiplos5}");
            Console.ReadKey();
        }
    }
}