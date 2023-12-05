using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio04
    {
        public void Executarexercicioquatro()
        {
            //Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição
            //e multiplicação entre os valores lidos, baseando-se na utilização do conceito de
            //propriedade distributiva. Dica: se forem lidas as variáveis A, B, C e D, devem ser somados
            //e multiplicados os valores de A com B, A com C e A com D; depois B com C, B com D e por
            //último C com D. Note que para cada operação serão utilizadas seis combinações.Assim sendo,
            //devem ser realizadas doze operações de processamento, sendo seis para as adições e seis
            //para as multiplicações.

            Console.WriteLine("Exercicio 04 - algoritmo para ler e apresentar o resultado dois a dois da adição e multiplicação.");
            Console.ReadKey();

            Console.Write("Digite o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Resultados das SOMAS:");
            Console.WriteLine($"A + B = {a + b}");
            Console.WriteLine($"A + C = {a + c}");
            Console.WriteLine($"A + D = {a + d}");
            Console.WriteLine($"B + C = {b + c}");
            Console.WriteLine($"B + D = {b + d}");
            Console.WriteLine($"C + D = {c + d}");
            Console.ReadKey();

            Console.WriteLine($"Resultados das MULTIPLICAÇÕES:");
            Console.WriteLine($"A * B = {a * b}");
            Console.WriteLine($"A * C = {a * c}");
            Console.WriteLine($"A * D = {a * d}");
            Console.WriteLine($"B * C = {b * c}");
            Console.WriteLine($"B * D = {b * d}");
            Console.WriteLine($"C * D = {c * d}");
            Console.ReadKey();

        }
    }
}
