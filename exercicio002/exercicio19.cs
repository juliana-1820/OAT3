using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio19
    {
        public void Executarexerciciodezenove()
        {
            //Escreva um programa que leia três valores para os lados de um triângulo
            //(variáveis A, B e C). Verificar se cada lado é menor que a soma dos outros
            //dois lados. Se sim, saber de A==B e se B==C, sendo verdade o triângulo é
            //eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade
            //o triângulo é isósceles; e caso contrário, o triângulo será escaleno. Caso
            //os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência. 


            Console.WriteLine("Exercicio 19 - algoritmo para ler os lados de um triângulo.");
            Console.ReadKey();

            Console.Write("Digite o valor para o lado A: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor para o lado B: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor para o lado C: ");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo.");
            }

            Console.ReadKey();

        }
    }
}
