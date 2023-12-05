using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio22
    {
        public void Executarexerciciovinteedois()
        {
            //Faça um programa que leia um número. Se positivo armazene-o em A, se for
            //negativo, em B. No final mostrar o resultado.


            Console.WriteLine("Exercicio 22 - algoritmo para um número em A ou B.");
            Console.ReadKey();

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 0;

            if (numero > 0)
            {
                a = numero;
            }
            else if (numero < 0)
            {
                b = numero;
            }

            Console.WriteLine($"Número positivo (A): {a}");
            Console.WriteLine($"Número negativo (B): {b}");

            Console.ReadKey();

        }
    }
}