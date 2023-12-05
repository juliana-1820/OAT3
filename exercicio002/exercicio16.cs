using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio16
    {
        public void Executarexerciciodezesseis()
        {

            //Escreva um programa que leia dois números e exiba mensagem informando o
            //valor do maior número e o valor do menor número. Se os dois números forem
            //iguais, o programa deve exibir mensagem informando este fato.


            Console.WriteLine("Exercicio 16 - algoritmo para mostrar qual número é o maior e o menor.");
            Console.ReadKey();

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"O maior número é: {numero1}");
                Console.WriteLine($"O menor número é: {numero2}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O maior número é: {numero2}");
                Console.WriteLine($"O menor número é: {numero1}");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }

            Console.ReadKey();
        }
    }
}
