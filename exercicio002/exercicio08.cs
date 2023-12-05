using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio08
    {
        public void Executarexerciciooito()
        {
            //Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a
            //fórmula: V = 3.14159 * R * R * A. Onde as variáveis: V, R e A representam
            //respectivamente o volume, o raio e a altura.


            Console.WriteLine("Exercicio 08- algoritmo para apresentar o volume de uma lata de óleo.");
            Console.ReadKey();


            Console.Write("Digite o raio da lata de óleo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da lata de óleo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = 3.14159 * raio * raio * altura;

            Console.WriteLine($"Volume da lata de óleo é: {volume:F2}");
            Console.ReadKey();

        }
    }
}
