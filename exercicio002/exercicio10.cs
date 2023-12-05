using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio10
    {
        public void Executarexerciciodez()
        {

            //Escrever um programa que leia dois números inteiros e mostre todos os
            //relacionamentos de ordem existentes entre eles. Os relacionamentos
            //possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual. 


            Console.WriteLine("Exercicio 10 - algoritmo para ler dois números e suas relações.");
            Console.ReadKey();


            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Relacionamentos de Ordem:");
            Console.WriteLine($"{numero1} == {numero2}: {numero1 == numero2}");
            Console.WriteLine($"{numero1} != {numero2}: {numero1 != numero2}");
            Console.WriteLine($"{numero1} > {numero2}: {numero1 > numero2}");
            Console.WriteLine($"{numero1} < {numero2}: {numero1 < numero2}");
            Console.WriteLine($"{numero1} >= {numero2}: {numero1 >= numero2}");
            Console.WriteLine($"{numero1} <= {numero2}: {numero1 <= numero2}");
            Console.ReadKey();

        }
    }
}
