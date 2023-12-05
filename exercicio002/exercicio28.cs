using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio28
    {
        public void Executarexerciciovinteeoito()
        {
            //Faça um programa que gera e escreve os números ímpares dos números lidos entre
            //100 e 200. 


            Console.WriteLine("Exercicio 28 - algoritmo que mostre ímpares entre 100 e 200.");
            Console.ReadKey();

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}