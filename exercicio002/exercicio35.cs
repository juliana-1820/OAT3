using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio35
    {
        public void Executarexerciciotrintaecinco()
        {
            //Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma
            //mensagem: "Múltiplo de 10".

            Console.WriteLine("Exercicio 35 - algoritmo que conte de 1 até 100. ");
            Console.ReadKey();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine($"{i} é um múltiplo de 10");
                    Console.ReadKey();
                }
            }

        }
    }
}