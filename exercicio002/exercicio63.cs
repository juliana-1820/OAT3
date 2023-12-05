using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio63
    {
        public void Executarexerciciosessentaetres()
        {
            //Escreva um programa que verifique se um número é par ou ímpar através de um
            //método chamado VERIFICA. O método deverá receber um número inteiro (n) e deverá
            //retornar a mensagem "PAR" ou "ÍMPAR”.


            Console.WriteLine("Exercicio 63 - programa método par ou ímpar. ");
            Console.ReadKey();


            Console.Write("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string resultado = Verifica(n);
            Console.WriteLine("O número é: " + resultado);
            Console.ReadKey();
        }

        public static string Verifica(int n)
        {
            if (n % 2 == 0)
                return "PAR";
            else
                return "ÍMPAR";
        }
    }
}