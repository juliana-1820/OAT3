using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio30
    {
        public void Executarexerciciotrinta()
        {
            //Faça um programa para imprimir uma tabuada.

            Console.WriteLine("Exercicio 30 - algoritmo que mostre uma tabuada.");
            Console.ReadKey();


            Console.Write("Digite um número para ver a sua tabuada: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero * i);
            }
            Console.ReadKey();
        }
    }
}