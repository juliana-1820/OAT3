using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio34
    {
        public void Executarexerciciotrintaequatro()
        {
            //Escreva um programa que leia um conjunto de números positivos e exiba o
            //menor e o maior. Suporemos que o número de elementos deste conjunto não
            //é conhecido, e que um número negativo será utilizado para sinalizar o fim
            //dos dados.


            Console.WriteLine("Exercicio 34 - algoritmo que leia um conjunto de números positivos e exiba o menor e o maior. ");
            Console.ReadKey();

            List<int> numeros = new List<int>();
            int numero;

            Console.WriteLine("Digite números positivos (um número negativo encerra o programa):");

            do
            {
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 0)
                {
                    numeros.Add(numero);
                }
            } while (numero >= 0);

            int menor = numeros[0];
            int maior = numeros[0];

            foreach (int num in numeros)
            {
                if (num < menor)
                {
                    menor = num;
                }

                if (num > maior)
                {
                    maior = num;
                }
            }

            Console.WriteLine("O menor número é " + menor);
            Console.WriteLine("O maior número é " + maior);
            Console.ReadKey();
        }
    }
}