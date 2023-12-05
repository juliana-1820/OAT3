using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio01
    {
        public void Executarexercicioum()
        {
            //Faça um programa para calcular o estoque médio de uma peça, sendo que: 
            //ESTOQUE MÉDIO = (QUANTIDADE MÍNIMA + QUANTIDADE MÁXIMA) / 2.

            Console.WriteLine("Exercicio 01 - algoritmo que calcule o estoque médio de uma peça");
            Console.ReadKey();

            int qtdmi, qtdma, estoque;

            Console.Write("Digite a quantidade mínima da peça: ");
            qtdmi = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade máxima da peça: ");
            qtdma = int.Parse(Console.ReadLine());

            estoque = qtdmi + qtdma / 2;

            Console.WriteLine("O estoque médio da peça é: " + estoque);


        }
    }
}
