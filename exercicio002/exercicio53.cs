using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio53
    {
        public void Executarexerciciocinquentaetres()
        {

            //Durante uma corrida de automóveis com N voltas de duração foram anotados para
            //um piloto, na ordem, os tempos registrados em cada volta.Fazer um programa
            //para ler os tempos das N voltas, calcular e imprimir: i.melhor tempo; ii.a volta
            //em que o melhor tempo ocorreu; iii.tempo médio das N voltas;



            Console.WriteLine("Exercicio 53 - algoritmo para ler os tempos das N voltas de uma corrida. ");
            Console.ReadKey();



            Console.Write("Digite o número de voltas: ");
            int N = int.Parse(Console.ReadLine());

            double[] tempos = new double[N];
            double soma = 0, melhorTempo = double.MaxValue;
            int voltaMelhorTempo = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite o tempo da volta {i + 1}: ");
                tempos[i] = double.Parse(Console.ReadLine());
                soma += tempos[i];

                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }
            }

            double media = soma / N;

            Console.WriteLine($"O melhor tempo foi {melhorTempo} na volta {voltaMelhorTempo}.");
            Console.WriteLine($"O tempo médio das voltas foi {media}.");
            Console.ReadKey();
        }
    }
}