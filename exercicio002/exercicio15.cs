using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio15
    {
        public void Executarexercicioquinze()
        {
            //Escreva um programa que leia quatro notas escolares de um aluno e apresente
            //uma mensagem que o aluno foi aprovado se o valor da média escolar for
            //maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota do
            //recuperação, somar com o valor da média e obter a nova média. Se a nova média
            //for maior ou igual a 7, apresentar uma mensagem informando que o aluno foi
            //aprovado na recuperação. Se o aluno não foi aprovado, apresentar uma mensagem
            //informando esta condição. Apresentar junto com as mensagens o valor da média
            //do aluno. 


            Console.WriteLine("Exercicio 15 - algoritmo para apresentar notas de um aluno.");
            Console.ReadKey();


            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine($"Você foi aprovado com a média: {media:F2}");
            }
            else
            {
                Console.Write("Digite a nota da recuperação: ");
                double notaRecuperacao = Convert.ToDouble(Console.ReadLine());

                double novaMedia = (media + notaRecuperacao) / 2;

                if (novaMedia >= 7)
                {
                    Console.WriteLine($"Parabéns! Você foi aprovado na recuperação com a média: {novaMedia:F2}");
                }
                else
                {
                    Console.WriteLine($"Você foi reprovado. Sua média final é: {novaMedia:F2}");
                }
            }

            Console.ReadKey();

        }
    }
}
