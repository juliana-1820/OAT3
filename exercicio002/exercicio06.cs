using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio06
    {
        public void Executarexercicioseis()
        {
            //Ler uma temperatura em graus Celsius e apresentá-la convertida em graus
            //Fahrenheit. A fórmula de conversão de temperatura a ser utilizada é
            //F = (9* C + 160) / 5, em que a variável F representa é a temperatura em
            //graus Fahrenheit e a variável C representa é a temperatura em graus Celsius. 


            Console.WriteLine("Exercicio 06- algoritmo para ler temperatura em Celsius");
            Console.ReadKey();


            Console.Write("Digite a temperatura em graus Celsius: ");
            double temperaturaC = Convert.ToDouble(Console.ReadLine());

            double temperaturaF = (9 * temperaturaC + 160) / 5;

            Console.WriteLine($"A temperatura em graus Fahrenheit é: {temperaturaF:F2} °F");
            Console.ReadKey();
        }
    }
}
