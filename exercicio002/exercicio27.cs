using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio27
    {
        public void Executarexerciciovinteesete()
        {//Escreva um programa que leia: a quantidade de números que deverá processar;
            //os números que deverá processar,e calcule e exiba, para cada número a ser
            //processado o seu fatorial. Lembrete: O fatorial de um número N é dado
            //pela fórmula: N != 1 * 2 * 3 * 4 * 5 * ... *N


            Console.WriteLine("Exercicio 27 - algoritmo que mostre o fatorial.");
            Console.ReadKey();

            Console.Write("Digite a quantidade de números que deseja processar: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o número para calcular o fatorial: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                long fatorial = Fatorial(numero);

                Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
            }
        }

        static long Fatorial(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * Fatorial(numero - 1);
            }
        }

    }

}
