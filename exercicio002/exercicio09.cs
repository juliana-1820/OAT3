using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio09
    {
        public void Executarexercicionove()
        {
            //Faça um algoritmo que leia a idade de uma pessoa expressa em anos,
            //meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
            //Considerar ano com 365 dias e mês com 30 dias. 


            Console.WriteLine("Exercicio 09 - algoritmo para ler a idade de uma pessoa.");
            Console.ReadKey();

            Console.Write("Digite a sua idade em anos: ");
            int anos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a sua idade em meses: ");
            int meses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a sua idade em dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Idade em dias: {dias} dias");
            Console.ReadKey();


        }
    }
}
