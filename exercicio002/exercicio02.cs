using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio02
    {
        public void Executarexerciciodois()
        {
            //Faça um programa que: leia a cotação do dólar, um valor em dólares, converta esse valor para
            //Real e que mostre o resultado.

            double cotacao, vdolar, vreal;

            Console.WriteLine("Exercicio 02 - algoritmo que: leia a cotação do dólar, um valor em dólares, converta esse valor para Real e que mostre o resultado");
            Console.ReadKey();

            Console.Write("Digite a cotação do dólar: ");
            cotacao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor em dólares: ");
            vdolar = Convert.ToDouble(Console.ReadLine());

            vreal = vdolar * cotacao;

            Console.WriteLine($"O valor em Reais é: {vreal:N2}");

            Console.ReadKey();


        }
    }
}
