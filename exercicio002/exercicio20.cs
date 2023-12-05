using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio20
    {
        public void Executarexerciciovinte()
        {
            //Escrever um programa declarando três variáveis do tipo inteiro (a, b e c).
            //Ler um valor maior que zero para cada variável (se o valor digitado não é
            //válido, mostrar mensagem e ler novamente). Exibe o menor valor lido multiplicado
            //pelo maior e o maior valor dividido pelo menor. 


            Console.WriteLine("Exercicio 20 - algoritmo para ler o maior e o menor número.");
            Console.ReadKey();


            int a, b, c;

            do
            {
                Console.Write("Digite um valor maior que zero para A: ");
            }
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);

            do
            {
                Console.Write("Digite um valor maior que zero para B: ");
            }
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);

            do
            {
                Console.Write("Digite um valor maior que zero para C: ");
            }
            while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);

            int menor = Math.Min(Math.Min(a, b), c);
            int maior = Math.Max(Math.Max(a, b), c);

            Console.WriteLine($"Menor valor ({menor}) multiplicado pelo maior valor ({maior}): {menor * maior}");

            if (menor != 0)
            {
                Console.WriteLine($"Maior valor ({maior}) dividido pelo menor valor ({menor}): {maior / (double)menor}");
            }
            else
            {
                Console.WriteLine("Não é possível calcular a divisão, pois o menor valor é zero.");
            }

            Console.ReadKey();


        }
    }
}