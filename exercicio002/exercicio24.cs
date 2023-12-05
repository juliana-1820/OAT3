using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio24
    {
        public void Executarexerciciovinteequatro()
        {
            //Escreva um programa que leia dois números inteiros e apresente as opções
            //para usuário escolher o que deseja realizar:
            //1 - Verificar se um dos números lidos é ou não múltiplo do outro
            //2 - Verificar se os dois números lidos são pares
            //3 - Verificar se a média dos dois números é maior ou igual a 7
            //4 - Sair


            Console.WriteLine("Exercicio 24 - algoritmo menu para verificar se dois números...");
            Console.ReadKey();


            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
                Console.WriteLine("2 - Verificar se ambos os números são pares");
                Console.WriteLine("3 - Verificar se a média dos números é maior ou igual a 7");
                Console.WriteLine("4 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 4)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                Console.Write("Digite o primeiro número inteiro: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número inteiro: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        if (num1 % num2 == 0 || num2 % num1 == 0)
                            Console.WriteLine("Um dos números é múltiplo do outro.");
                        else
                            Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                        break;
                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                            Console.WriteLine("Ambos os números são pares.");
                        else
                            Console.WriteLine("Pelo menos um dos números não é par.");
                        break;
                    case 3:
                        double media = (num1 + num2) / 2.0;
                        if (media >= 7)
                            Console.WriteLine($"A média dos números é {media}, que é maior ou igual a 7.");
                        else
                            Console.WriteLine($"A média dos números é {media}, que é menor que 7.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
