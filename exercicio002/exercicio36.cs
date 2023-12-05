using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio36
    {
        public void Executarexerciciotrintaeseis()
        {
            //Faça um programa que leia 10 valores inteiros e positivos e:
            //Encontre o maior valor       
            //Encontre o menor valor
            //Calcule a média dos números lidos


            Console.WriteLine("Exercicio 36 - algoritmo que 10 valores inteiros e positivos. ");
            Console.ReadKey();


            int[] numeros = new int[10];
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro positivo: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                soma += numeros[i];
            }

            Array.Sort(numeros);

            Console.WriteLine("O maior valor é " + numeros[9]);
            Console.WriteLine("O menor valor é " + numeros[0]);
            Console.WriteLine("A média dos números é " + soma / 10.0);
            Console.ReadKey();

        }
    }
}
