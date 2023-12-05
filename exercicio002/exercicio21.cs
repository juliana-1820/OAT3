using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio21
    {
        public void Executarexerciciovinteeum()
        {

            //Faça um programa que leia um número inteiro e mostre uma mensagem na tela
            //indicando se este número é positivo ou negativo. Pare a execução do programa
            //quando o usuário requisitar. 

            Console.WriteLine("Exercicio 21 - algoritmo para mostrar se um número é positivo ou negativo.");
            Console.ReadKey();

            int numero;

            do
            {
                Console.Write("Digite um número inteiro (ou 0 para sair): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo.");
                }
                else
                {
                    Console.WriteLine("O número é zero.");
                }

            } while (numero != 0);

            Console.WriteLine("Programa encerrado.");

            Console.ReadKey();
        }
    }
}