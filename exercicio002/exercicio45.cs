using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio45
    {
        public void Executarexercicioquarentaecinco()
        {
            //Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem
            //inversa que foi realizada a leitura. 


            Console.WriteLine("Exercicio 45 - algoritmo para imprimir a ordem inversa de um vetor. ");
            Console.ReadKey();


            Console.Write("Digite o número de elementos na sequência: ");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o elemento {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A sequência na ordem inversa é:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();
        }
    }
}