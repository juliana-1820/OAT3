using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio39
    {
        public void Executarexerciciotrintaenove()
        {
            //Faça um programa que leia um número inteiro e mostre uma mensagem indicando
            //se este número é par ou ímpar, e se é positivo ou negativo. O programa só
            //deve parar de rodar quando o usuário responder "S" na seguinte pergunta,
            //"Deseja encerrar o programa?". 


            Console.WriteLine("Exercicio 39 - algoritmo que diga se um número é positivo ou negativo e par ou ímpar ");
            Console.ReadKey();


            int numero;
            string resposta = "";

            while (resposta != "S")
            {
                Console.Write("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }

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

                Console.Write("Deseja encerrar o programa? (S para sim, qualquer outra tecla para não): ");
                resposta = Console.ReadLine();
            }
        }
    }
}
