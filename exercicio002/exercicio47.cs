using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio47
    {
        public void Executarexercicioquarentaesete()
        {

            //Considere um vetor de 10 números inteiros positivos maiores que zero e um único
            //número inteiro, também positivo e maior que zero. Faça um programa para: a.ler
            //pelo teclado o vetor; b.ler pelo teclado o número X; C. dizer quantos números no
            //vetor são maiores que X, menores que X e iguais a X.


            Console.WriteLine("Exercicio 47 - algoritmo para ler um vetor de 10 números inteiros. ");
            Console.ReadKey();


            int[] vetor = new int[10];
            int x, maiores = 0, menores = 0, iguais = 0;

            Console.WriteLine("Digite os elementos do vetor:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o número X: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] > x)
                {
                    maiores++;
                }
                else if (vetor[i] < x)
                {
                    menores++;
                }
                else
                {
                    iguais++;
                }
            }

            Console.WriteLine($"Existem {maiores} números no vetor maiores que {x}.");
            Console.WriteLine($"Existem {menores} números no vetor menores que {x}.");
            Console.WriteLine($"Existem {iguais} números no vetor iguais a {x}.");
            Console.ReadKey();
        }
    }
}