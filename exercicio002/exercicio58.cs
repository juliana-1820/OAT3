using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio58
    {
        public void Executarexerciciocinquentaeoito()
        {
            //Fazer um programa para armazenar em um vetor, vários números inteiros e
            //positivos e calcular a média. Imprimir também o maior.A quantidade de números
            //lidos será definida pelo usuário.


            Console.WriteLine("Exercicio 58 - programa para armazenar em um vetor, vários números inteiros e calcular a média. ");
            Console.ReadKey();


            Console.Write("Digite a quantidade de números: ");
            int N = int.Parse(Console.ReadLine());

            int[] numeros = new int[N];
            int soma = 0, maior = int.MinValue;

            Console.WriteLine("Digite os números:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                soma += numeros[i];

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }

            double media = (double)soma / N;

            Console.WriteLine($"A média dos números é: {media}");
            Console.WriteLine($"O maior número é: {maior}");
            Console.ReadKey();
        }
    }
}