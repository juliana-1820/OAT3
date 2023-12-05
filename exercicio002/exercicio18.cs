using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio18
    {
        public void Executarexerciciodezoito()
        {

            //Escreva um programa que leia um número inteiro (variável CODIGO). Verificar
            //se o código é igual a 1, igual a 2 ou igual a 3. Caso não seja, apresentar
            //a mensagem "Código inválido". Ao ser verificado o código e constatado que é
            //um valor válido, o programa deve verificar cada código em separado para
            //eterminar seu valor por extenso, ou seja, apresentar a mensagem "um", "dois"
            //ou "três”. (Utilizar o comando Switch). 


            Console.WriteLine("Exercicio 18 - algoritmo para mostrar se um número é = a 1, 2 ou 3.");
            Console.ReadKey();

            Console.WriteLine("Digite um número: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }

            Console.ReadKey();
        }
    }
}
