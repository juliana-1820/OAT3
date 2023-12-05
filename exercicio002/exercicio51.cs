using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio51
    {
        public void Executarexerciciocinquentaeum()
        {
            //Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos
            //N alunos e calcular a média aritmética das notas. Contar quantos alunos estão
            //com a nota acima de 7.0. Obs.: Se nenhum aluno tirou nota acima de 5.0, imprimir
            //mensagem: Não há nenhum aluno com nota acima de 5. 


            Console.WriteLine("Exercicio 51 - algoritmo que leia uma quantidade N de alunos. E leia a nota de cada um dos N alunos e calcular a média aritmética das notas. ");
            Console.ReadKey();


            Console.Write("Digite a quantidade de alunos: ");
            int N = int.Parse(Console.ReadLine());

            double[] notas = new double[N];
            double soma = 0;
            int contagem = 0;

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
                soma += notas[i];

                if (notas[i] > 7.0)
                {
                    contagem++;
                }
            }

            double media = soma / N;

            Console.WriteLine($"A média aritmética das notas é: {media}");

            if (contagem > 0)
            {
                Console.WriteLine($"Existem {contagem} alunos com nota acima de 7.0");
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5.");
            }
            Console.ReadKey();
        }
    }
}