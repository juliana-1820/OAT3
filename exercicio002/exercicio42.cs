using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio42
    {
        public void Executarexercicioquarentaedois()
        {
            //Faça um programa que determine o maior e o menor entre N números lidos.
            //A condição de parada é a entrada de um valor 0, ou seja, o programa deve
            //ficar executando até que a entrada seja igual a 0(ZERO).


            Console.WriteLine("Exercicio 42 - algoritmo que determine o maior e menor número. ");
            Console.ReadKey();


            int numero, maior = int.MinValue, menor = int.MaxValue;

            Console.Write("Digite um número (0 para parar): ");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

                Console.Write("Digite um número (0 para parar): ");
                numero = int.Parse(Console.ReadLine());
            }

            if (maior == int.MinValue || menor == int.MaxValue)
            {
                Console.WriteLine("Nenhum número foi inserido.");
            }
            else
            {
                Console.WriteLine($"O maior número inserido foi: {maior}");
                Console.WriteLine($"O menor número inserido foi: {menor}");
            }
            Console.ReadKey();
        }
    }
}
