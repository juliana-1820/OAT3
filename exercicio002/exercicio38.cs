using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio38
    {
        public void Executarexerciciotrintaeoito()
        {
            //Faça um programa que leia as variáveis C e N, respectivamente código e número
            //de horas trabalhadas de um operário. E calcule o salário sabendo-se que ele
            //ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o
            //excesso de pagamento armazenando-o na variável E, caso contrário zerar tal
            //variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento
            //imprimir o salário total e o salário excedente. O programa só deve parar de
            //rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
            //programa?". 


            Console.WriteLine("Exercicio 38 - algoritmo que calcule o salário. ");
            Console.ReadKey();



            string C;
            int N;
            double salario, salarioExcedente;
            string resposta = "";

            while (resposta != "S")
            {
                salarioExcedente = 0;

                Console.Write("Digite o código do operário: ");
                C = Console.ReadLine();

                Console.Write("Digite o número de horas trabalhadas: ");
                N = int.Parse(Console.ReadLine());

                if (N > 50)
                {
                    salarioExcedente = (N - 50) * 20.00;
                    salario = 50 * 10.00 + salarioExcedente;
                }
                else
                {
                    salario = N * 10.00;
                }

                Console.WriteLine($"O salário total do operário {C} é R$ {salario:0.00}");
                Console.WriteLine($"O salário excedente do operário {C} é R$ {salarioExcedente:0.00}");

                Console.Write("Deseja encerrar o programa? (S para sim, qualquer outra tecla para não): ");
                resposta = Console.ReadLine();
            }
        }
    }
}

