using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio11
    {
        public void Executarexercicioonze()
        {
            //Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos
            //valores de modo que a variável A passe a possuir o valor da variável B,
            //e a variável B passe a possuir o valor da variável A. Apresentar os valores
            //trocados. 


            Console.WriteLine("Exercicio 11 - algoritmo para apresentar dois valores trocados.");
            Console.ReadKey();


            Console.Write("Digite o primeiro valor: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int x = a;
            a = b;
            b = x;

            Console.WriteLine($"Valores trocados: A = {a}, B = {b}");
            Console.ReadKey();

        }
    }
}
