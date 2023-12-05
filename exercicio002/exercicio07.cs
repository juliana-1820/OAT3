using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio07
    {
        public void Executarexerciciosete()
        {
            //Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus
            //Celsius. A fórmula de conversão de temperatura a ser utilizada é
            //C = (F - 32) * 5/9, em que a variável F é a temperatura em graus Fahrenheit
            //e a variável C é a temperatura em graus Celsius. 

            Console.WriteLine("Exercicio 07- algoritmo para ler temperatura em Fahrenheit");
            Console.ReadKey();


            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            double temperaturaF = Convert.ToDouble(Console.ReadLine());

            double temperaturaC = (temperaturaF - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em graus Celsius é: {temperaturaC:F2} °C");
            Console.ReadLine();
        }

    }
}
