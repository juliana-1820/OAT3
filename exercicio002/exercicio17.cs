using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio17
    {
        public void Executarexerciciodezessete()
        {
            //Escreva um programa que leia um número inteiro. Verificar por meio de uma
            //estrutura condicional se o valor fornecido está na faixa entre 0 (zero) e 9
            //(nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem
            //"valor válido". Caso contrário, apresentar a mensagem "valor inválido". 


            Console.WriteLine("Exercicio 17 - algoritmo para mostrar se um número está entre 0 e 9.");
            Console.ReadKey();


            Console.Write("Digite um número entre 0 e 9: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }

            Console.ReadKey();
        }
    }
}
