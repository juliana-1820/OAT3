using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio31
    {
        public void Executarexerciciotrintaeum()
        {
            //Escrever um programa que leia um conjunto de números positivos, e exiba se o
            //número lido é par ou ímpar. Exiba ao final a soma total dos números pares lidos
            //e também a soma dos números ímpares lidos. Suporemos que o número de elementos
            //deste conjunto não é conhecido, e que um número negativo será utilizado para
            //sinalizar o fim dos dados.


            Console.WriteLine("Exercicio 31 - algoritmo que mostre um conjunto de números positivos, e exiba se o número lido é par ou ímpar. ");
            Console.ReadKey();


            int somaPares = 0;
            int somaImpares = 0;
            int numero;

            Console.WriteLine("Digite os números positivos (um número negativo encerra o programa e mostrará a soma dos conjuntos):");

            do
            {
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine(numero + " é par.");
                        somaPares += numero;
                    }
                    else
                    {
                        Console.WriteLine(numero + " é ímpar.");
                        somaImpares += numero;
                    }
                }
            } while (numero >= 0);

            Console.WriteLine("A soma dos números pares é " + somaPares);
            Console.WriteLine("A soma dos números ímpares é " + somaImpares);
            Console.ReadKey();

        }
    }
}