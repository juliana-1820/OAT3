using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio33
    {
        public void Executarexerciciotrintaetres()
        {
            //Escreva um programa que calcule e exiba a média da nota dos alunos de uma
            //turma em uma prova. O número de alunos é desconhecido. Os dados de um aluno
            //são: número de matrícula e a sua nota na prova em questão.


            Console.WriteLine("Exercicio 33 - algoritmo que calcule a média da nota dos alunos de uma turma em uma prova. O número de alunos é desconhecido. ");
            Console.ReadKey();

            List<double> notas = new List<double>();
            string continuar = "";

            do
            {
                Console.Write("Digite o número de matrícula do aluno: ");
                string matricula = Console.ReadLine();

                Console.Write("Digite a nota do aluno: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                notas.Add(nota);

                Console.Write("Deseja adicionar outro aluno? (s/n): ");
                continuar = Console.ReadLine();
            } while (continuar.ToLower() == "s");

            double soma = 0;

            foreach (double nota in notas)
            {
                soma += nota;
            }

            double media = soma / notas.Count;

            Console.WriteLine("A média das notas dos alunos é " + media);
            Console.ReadKey();

        }
    }
}
