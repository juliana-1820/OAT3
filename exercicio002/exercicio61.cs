using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio61
    {
        public void Executarexerciciosessentaeum()
        {
            //Escreva um programa que calcule e retorne o salário atualizado através do
            //método REAJUSTE. O método deve receber o valor do salário e o índice de
            //reajuste.


            Console.WriteLine("Exercicio 61 - programa que calcule e retorne o salário atualizado. ");
            Console.ReadKey();


            Console.Write("Digite o valor do salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o índice de reajuste: ");
            double indiceReajuste = Convert.ToDouble(Console.ReadLine());

            double salarioAtualizado = Reajuste(salario, indiceReajuste);
            Console.WriteLine("O salário atualizado é: " + salarioAtualizado);
            Console.ReadKey();
        }

        public static double Reajuste(double salario, double indiceReajuste)
        {
            return salario + (salario * indiceReajuste);
        }
    }
}