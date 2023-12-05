using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio50
    {
        public void Executarexerciciocinquenta()
        {
            //Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário
            //(sem conhecer o número sorteado) tente acertar. Caso não acerte, o programa deve
            //imprimir uma mensagem informando se o número sorteado é maior ou menor que a
            //tentativa feita. Ao acertar o número, o programa deve imprimir a quantidade de
            //tentativas feitas. 


            Console.WriteLine("Exercicio 50 - algoritmo que sorteie um número de 0 a 100. ");
            Console.ReadKey();


            Random random = new Random();
            int numeroSorteado = random.Next(0, 101);
            int tentativas = 0;
            int palpite;

            Console.WriteLine("Tente adivinhar o número que eu sorteei entre 0 e 100!");

            do
            {
                Console.Write("Digite o seu palpite: ");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite > numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é menor!");
                }
                else if (palpite < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior!");
                }
            }
            while (palpite != numeroSorteado);

            Console.WriteLine($"Parabéns, você acertou o número depois de {tentativas} tentativas!");
            Console.ReadLine();
        }
    }
}
