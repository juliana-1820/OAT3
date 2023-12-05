using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio14
    {
        public void Executarexercicioquatorze()
        {
            //Escreva um programa que leia dois números e apresente a diferença do
            //maior para o menor. 


            Console.WriteLine("Exercicio 14 - algoritmo para apresentar a diferença entre dois números.");
            Console.ReadKey();

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double diferenca;

            if (num1 > num2)
            {
                diferenca = num1 - num2;
                Console.WriteLine($"A diferença do maior para o menor é: {diferenca}");
            }
            else if (num2 > num1)
            {
                diferenca = num2 - num1;
                Console.WriteLine($"A diferença do maior para o menor é: {diferenca}");
            }
            else
            {
                Console.WriteLine("Os números são iguais, a diferença é zero.");
            }

            Console.ReadKey();

        }
    }
}
