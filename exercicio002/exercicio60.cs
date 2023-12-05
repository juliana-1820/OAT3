using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio60
    {
        public void Executarexerciciosessenta()
        {

            //Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através
            //de um método chamado VERIFICA_QUADRANTE, que deve receber um valor para x e
            //um valor para y. 


            Console.WriteLine("Exercicio 60 - programa VERIFICA_QUADRANTE. ");
            Console.ReadKey();


            int x, y;

            Console.WriteLine("Digite X");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Y");
            y = int.Parse(Console.ReadLine());

            if (x != 0 & y != 0)
            {

                if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro quadrante\n");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo quadrante\n");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro quadrante\n");
                else
                    Console.WriteLine("Quarto quadrante\n");
            }
            Console.ReadKey();
        }
    }
}