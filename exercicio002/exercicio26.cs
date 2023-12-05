using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio26
    {
        public void Executarexerciciovinteeseis()
        {
            //Escreva um programa que exiba os números de 1 a 100 na tela em ordem
            //decrescente. 

            Console.WriteLine("Exercicio 26 - algoritmo que mostre os númeors de 1 a 100.");
            Console.ReadKey();


            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
