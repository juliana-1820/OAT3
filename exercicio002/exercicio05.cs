using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio002
{
    public class Exercicio05
    {
        public void Executarexerciciocinco()
        {

            //Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem,
            //utilizando um automóvel que faz 12 Km por litro. Para obter o cálculo, o usuário
            //deve fornecer o tempo gasto na viagem e a velocidade média. Desta forma, será
            //possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO *
            //VELOCIDADE. Tendo o valor da distância, basta calcular a quantidade de litros
            //de combustível utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12.
            //O programa deve apresentar os valores da velocidade média, tempo gasto, a
            //distância percorrida e a quantidade de litros utilizada na viagem. Dica:
            //trabalhe com valores reais. 


            Console.WriteLine("Exercicio 05- algoritmo para calcular a quantidade de litros de combustível");
            Console.ReadKey();

            Console.Write("Digite o tempo gasto na viagem (em horas): ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade média durante a viagem (em Km/h): ");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            double distancia = tempo * velocidade;

            double litros_usados = distancia / 12;

            Console.WriteLine($"Velocidade Média foi: {velocidade} Km/h");
            Console.WriteLine($"Tempo Gasto foi: {tempo} horas");
            Console.WriteLine($"Distância Percorrida foi: {distancia} Km");
            Console.WriteLine($"Litros de Combustível Utilizados Foram: {litros_usados:F2} litros");
            Console.ReadKey();

        }
    }

}