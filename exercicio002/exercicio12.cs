using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio12
    {
        public void Executarexerciciodoze()
        {
            //Escreva um programa que leia um número inteiro e exiba o seu módulo. O módulo
            //de um número x é: x se x é maior ou igual a zero. x * (-1) se x é menor que
            //zero


            Console.WriteLine("Exercicio 12 - algoritmo para apresentar o módulo de um número.");
            Console.ReadKey();

            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int modulo;

            if (num >= 0)
            {
                modulo = num;
            }
            else
            {
                modulo = num * (-1);
            }

            Console.WriteLine($"O módulo do número é: {modulo}");
            Console.ReadKey();

        }
    }
}
