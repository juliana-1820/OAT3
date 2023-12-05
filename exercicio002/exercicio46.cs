using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio46
    {
        public void Executarexercicioquarentaeseis()
        {

            //Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar
            //desses vetores. Ou seja, realizar a soma de todos dos resultados da
            //multiplicação de x[i] por y[i]. 


            Console.WriteLine("Exercicio 46 - algoritmo para realizar a soma de todos dos resultados da multiplicação de x[i] por y[i] de dois vetores. ");
            Console.ReadKey();


            Console.Write("Digite o número de elementos nos vetores: ");
            int n = int.Parse(Console.ReadLine());

            int[] vetorX = new int[n];
            int[] vetorY = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o elemento {i + 1} do vetor X: ");
                vetorX[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o elemento {i + 1} do vetor Y: ");
                vetorY[i] = int.Parse(Console.ReadLine());
            }

            int produtoEscalar = 0;
            for (int i = 0; i < n; i++)
            {
                produtoEscalar += vetorX[i] * vetorY[i];
            }

            Console.WriteLine($"O produto escalar dos vetores X e Y é: {produtoEscalar}");
            Console.ReadKey();
        }
    }
}
