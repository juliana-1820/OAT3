using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio13
    {
        public void Executarexerciciotreze()
        {
            //Escreva um programa que leia 3 números inteiros e imprima na tela os
            //valores em ordem decrescente. 


            Console.WriteLine("Exercicio 13 - algoritmo para apresentar 3 números em ordem descrescente.");
            Console.ReadKey();

            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                int x = num1;
                num1 = num2;
                num2 = x;
            }

            if (num2 < num3)
            {
                int x = num2;
                num2 = num3;
                num3 = x;
            }

            if (num1 < num2)
            {
                int x = num1;
                num1 = num2;
                num2 = x;
            }

            Console.WriteLine($"Números em ordem decrescente: {num1}, {num2}, {num3}");
            Console.ReadKey();

        }
    }
}
