using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio48
    {
        public void Executarexercicioquarentaeoito()
        {
            //Uma agência de publicidade pediu à agência de modelos Luz & Beleza para
            //encontrar uma modelo que tenha idade entre 18 e 20 anos para participar de uma
            //campanha publicitária milionária de produtos de beleza. Foram inscritas 20
            //candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações
            //foram armazenadas em 2 vetores distintos. Faça um programa para imprima o
            //vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para
            //a campanha milionária. 


            Console.WriteLine("Exercicio 48 - algoritmo que imprima o vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para a campanha milionária. ");
            Console.ReadKey();


            string[] nomes = new string[20];
            int[] idades = new int[20];
            List<string> candidatasAptas = new List<string>();

            Console.WriteLine("Digite os nomes e idades das candidatas:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Nome da candidata {i + 1}: ");
                nomes[i] = Console.ReadLine();
                Console.Write($"Idade da candidata {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());

                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    candidatasAptas.Add(nomes[i]);
                }
            }

            Console.WriteLine("Candidatas aptas a concorrer a uma vaga para a campanha milionária:");
            foreach (string nome in candidatasAptas)
            {
                Console.WriteLine(nome);
                Console.ReadKey();
            }

        }
    }
}