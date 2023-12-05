using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio25
    {
        public void Executarexerciciovinteecinco()
        {
            //Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa
            //que calcule seu peso ideal, utilizando as seguintes fórmulas: (h = altura)
            //Para homens: (72.7 * h) - 58
            //Para mulheres: (62.1 * h) - 44.7


            Console.WriteLine("Exercicio 25 - algoritmo para calcular o peso ideal.");
            Console.ReadKey();

            Console.WriteLine("Digite a altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo (M para masculino, F para feminino):");
            string sexo = Console.ReadLine();

            double pesoIdeal;

            if (sexo == "M")
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"O peso ideal para um homem com {altura} metros de altura é: {pesoIdeal} kg");
            }
            else if (sexo == "F")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"O peso ideal para uma mulher com {altura} metros de altura é: {pesoIdeal} kg");
            }
            else
            {
                Console.WriteLine("Opção de sexo inválida. Digite M para masculino ou F para feminino.");
            }
            Console.ReadKey();
        }
    }
}