using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio32
    {
        public void Executarexerciciotrintaedois()
        {

            //Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros
            //números inteiros positivos ímpares a partir do número informado pelo usuário
            //menor que 10 e maior que zero. 


            Console.WriteLine("Exercicio 32 - algoritmo que calcule e exiba a soma dos quadrados dos 20... ");
            Console.ReadKey();


            Console.Write("Digite um número inteiro positivo menor que 10 e maior que zero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 1 || numero > 9)
            {
                Console.WriteLine("Número inválido. O número deve ser menor que 10 e maior que zero.");
                return;
            }

            int contador = 0;
            int soma = 0;

            while (contador < 20)
            {
                if (numero % 2 != 0)
                {
                    soma += numero * numero;
                    contador++;
                }
                numero++;
            }

            Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares é " + soma);
            Console.ReadKey();
        }
    }
}