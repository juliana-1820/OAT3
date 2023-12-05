using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio44
    {
        public void Executarexercicioquarentaequatro()
        {
            //Faça um programa que exiba as opções: 1 - Conversão de Graus Celsius em Graus
            //Fahrenheit. 2 - Conversão de Graus Fahrenheit em Graus Celsius. 3 - Peso ideal
            //do homem. 4 - Peso ideal da mulher. O programa só deve encerrar quando o usuário
            //digitar  ́S ́ para a pergunta “Deseja encerrar o programa?" Obs.: Nas opções 3 e 4
            //informar se o usuário está acima ou abaixo do peso ideal. 


            Console.WriteLine("Exercicio 44 - algoritmo para calcular graus e peso ideal. ");
            Console.ReadKey();

            string resposta = "";

            while (resposta != "S")
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Graus Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        double fahrenheit = celsius * 9 / 5 + 32;
                        Console.WriteLine($"A temperatura em Graus Fahrenheit é {fahrenheit}.");
                        break;
                    case 2:
                        Console.Write("Digite a temperatura em Graus Fahrenheit: ");
                        fahrenheit = double.Parse(Console.ReadLine());
                        celsius = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine($"A temperatura em Graus Celsius é {celsius}.");
                        break;
                    case 3:
                        Console.Write("Digite a sua altura em metros: ");
                        double alturaHomem = double.Parse(Console.ReadLine());
                        double pesoIdealHomem = (72.7 * alturaHomem) - 58;
                        Console.WriteLine($"O seu peso ideal é {pesoIdealHomem} kg.");
                        break;
                    case 4:
                        Console.Write("Digite a sua altura em metros: ");
                        double alturaMulher = double.Parse(Console.ReadLine());
                        double pesoIdealMulher = (62.1 * alturaMulher) - 44.7;
                        Console.WriteLine($"O seu peso ideal é {pesoIdealMulher} kg.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.Write("Deseja encerrar o programa? (S para sim, qualquer outra tecla para não): ");
                resposta = Console.ReadLine();
            }
        }
    }
}
